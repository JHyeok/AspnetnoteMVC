using AspnetNote.MVC6.DataContext;
using AspnetNote.MVC6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;

namespace AspnetNote.MVC6.Controllers
{
    public class NoteController : Controller
    {
        /// <summary>
        /// 게시판 리스트
        /// </summary>
        /// <returns></returns>
        /// 비동기 및 페이징기능 추가
        /// 검색 기능 추가
        public async Task<IActionResult> Index(string searchType, string search, int page = 1)
        {
            using (var db = new AspnetNoteDbContext())
            {
                // Notes 와 User 테이블 조인
                //var UsersWithNotes = db.Notes.Include(uwn => uwn.User).OrderByDescending(uwn => uwn.NoteNo).ToListAsync();
                //return View(await UsersWithNotes);
                var query = db.Notes.AsNoTracking().Include(uwn => uwn.User).OrderByDescending(uwn => uwn.NoteNo).AsQueryable();
                
                // select box 검색 기능 추가
                if (!string.IsNullOrWhiteSpace(search))
                {
                    switch (searchType)
                    {
                        case "NoteTitle":
                            query = query.Where(uwn => uwn.NoteTitle.Contains(search));
                            break;
                        case "UserName":
                            query = query.Where(uwn => uwn.User.UserName.Contains(search));
                            break;
                        case "NoteContents":
                            query = query.Where(uwn => uwn.NoteContents.Contains(search));
                            break;
                        case "NoteAll":
                            query = query.Where(uwn => uwn.NoteTitle.Contains(search) || uwn.NoteContents.Contains(search));
                            searchType = "NoteTitle";
                            break;
                        default:
                            query = query.Where(uwn => uwn.NoteTitle.Contains(search) || uwn.NoteContents.Contains(search));
                            searchType = "NoteTitle";
                            break;
                    }
                    // query = query.Where(uwn => uwn.NoteTitle.Contains(search));
                }

                var UsersWithNotes = await PagingList.CreateAsync(query, 10, page, "NoteNo", searchType);

                UsersWithNotes.RouteValue = new RouteValueDictionary
                {
                    {"filter", search}
                };
                return View(UsersWithNotes);
            }

        }

        /// <summary>
        /// 게시판 상세
        /// </summary>
        /// <param name="NoteNo"></param>
        /// <returns></returns>
        public async Task<IActionResult> Detail(int NoteNo)
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인이 안된 상태
                return RedirectToAction("Login", "Account");
            }
            using (var db = new AspnetNoteDbContext())
            {
                // Notes 와 User 테이블 조인
                var note = await db.Notes.Include(uwn => uwn.User).FirstOrDefaultAsync(n => n.NoteNo.Equals(NoteNo));
                return View(note);
            }
        }

        /// <summary>
        /// 게시물 추가
        /// </summary>
        /// <returns></returns>
        public IActionResult Add()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인이 안된 상태
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(Notes model)
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인이 안된 상태
                return RedirectToAction("Login", "Account");
            }
            model.UserNo = int.Parse(HttpContext.Session.GetInt32("USER_LOGIN_KEY").ToString());

            if (ModelState.IsValid)
            {
                using (var db = new AspnetNoteDbContext())
                {
                    await db.Notes.AddAsync(model);

                    if(db.SaveChanges() > 0)
                    {
                        return Redirect("index"); // 동일한 컨트롤 내 이동 
                    }
                }
                ModelState.AddModelError(string.Empty, "게시물을 저장할 수 없습니다.");
            }
            return View(model);
        }

        /// <summary>
        /// 게시물 수정
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit()
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인이 안된 상태
                return RedirectToAction("Login", "Account");
            }
            return Redirect("Add");
        }

        /// <summary>
        /// 게시물 삭제
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int NoteNo)
        {
            if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == null)
            {
                // 로그인이 안된 상태
                return RedirectToAction("Login", "Account");
            }
            using (var db = new AspnetNoteDbContext())
            {
                // Notes 와 User 테이블 조인
                var note = await db.Notes.Include(uwn => uwn.User).FirstOrDefaultAsync(n => n.NoteNo.Equals(NoteNo));
                if (HttpContext.Session.GetInt32("USER_LOGIN_KEY") == note.UserNo)
                {
                    db.Notes.Remove(note);
                    if (db.SaveChanges() > 0)
                    {
                        return Redirect("index");
                    }
                }
                // 메세지나 오류 처리 해야함 또는 오류페이지 만들어야 함
                return RedirectToAction("Error", "Home");
            }            
        }
    }
}
