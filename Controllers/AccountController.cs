using System.Linq;
using AspnetNote.MVC6.DataContext;
using AspnetNote.MVC6.Models;
using AspnetNote.MVC6.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspnetNote.MVC6.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        /// <summary>
        /// 로그인
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // ID, 비밀번호 - 필수
            if (ModelState.IsValid)
            {
                using (var db = new AspnetNoteDbContext())
                {
                    // Linq - 메서드 체이닝
                    // 데이터베이스에 있는 유저 테이블중 한개를 검색하는데 일치하는 것을.
                    // 익명람다식 사용. => : A Go To B
                    //var user = db.Users
                    //    .FirstOrDefault(u => u.UserId == model.UserId && u.UserPassword == model.UserPassword);
                    // 메모리 누수 방지
                    var user = db.Users
                        .FirstOrDefault(u => u.UserId.Equals(model.UserId) &&
                                        u.UserPassword.Equals(model.UserPassword));
                    //var user = db.Users.FirstOrDefault(u => u.UserId.Equals(model.UserId));
                    /* if (user == null)
                    {
                        // 로그인에 실패했을 때
                        ModelState.TryAddModelError(string.Empty, "사용자 ID 혹은 비밀번호가 올바르지 않습니다.");

                        // 사용자 ID 자체가 회원가입 X 경우 - 로그인에서는 권장하지 않는다. 회원가입에서나 권장.
                        // ModelState.TryAddModelError(string.Empty, "사용자 ID 가 존재않는다." );
                    }
                    else
                    {
                        // 로그인에 성공했을 때
                        return RedirectToAction("LoginSuccess", "Home"); // 로그인 성공 페이지로 이동
                    } */

                    // if 문 정리 else 가 없어도 논리적으로 동일하기 때문에 굳이 else 쓸 필요 없음.
                    // 실패메세지도 굳이 using 문 안에 있을 필요 없음.
                    if (user != null)
                    {
                        // 로그인에 성공했을 때
                        //HttpContext.Session.SetInt32(key, value); key는 특정 세션을 식별하는 식별자, value는 실제 데이터 값
                        HttpContext.Session.SetInt32("USER_LOGIN_KEY", user.UserNo);
                        return RedirectToAction("LoginSuccess", "Home"); // 로그인 성공 페이지로 이동
                    }
                }
                // 로그인에 실패했을 때
                ModelState.TryAddModelError(string.Empty, "사용자 ID 혹은 비밀번호가 올바르지 않습니다.");
            }
            return View(model);
        }     

        public IActionResult Logout()
        {
            // HttpContext.Session.Clear(); // 존재하는 모든 세션 삭제 , 여러 사람이로그인 했을 때 이걸 쓰면 모든 세션 날라가기 때문에 관리자들이 사용명령어
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// 회원가입 전송
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(User model)
        {
            // User.cs 의 Required 가 있는데 사용자가 폼에서 하나라도 입력을 안하면
            // IsValid 는 false를 반환함. Required가 있는 항목만 검사함
            if(ModelState.IsValid)
            {
                // java try(sqlsession){} catch(){}

                // C# 
                // using문을 써가지고 데이터컨텍스트를 데이터커넥션을 열고
                // using문이 끝나고 바깥에 나가면 자동으로 클로징이 되서 using문 사용
                using (var db = new AspnetNoteDbContext())
                {
                    // 메모리까지 올림
                    db.Users.Add(model);
                    // 실제 sql에 저장
                    db.SaveChanges(); // Commit
                }
                return RedirectToAction("index", "Home");
            }
            return View(model);
        }
    }
}
