using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetNote.MVC6.DataContext;
using AspnetNote.MVC6.Models;
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
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AspnetNoteDbContext())
                {
                    db.Users.Find(model.UserName, model.UserPassword);
                    // git second commit
                }
            }
            return View(model);
        }

        /// <summary>
        /// 회원가입
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
            return View();
        }

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
