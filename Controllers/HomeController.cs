using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspnetNote.MVC6.Models;
using AspnetNote.MVC6.DataContext;
using Microsoft.EntityFrameworkCore;

namespace AspnetNote.MVC6.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var db = new AspnetNoteDbContext())
            {
                var MainNote = await db.Notes.Include(uwn => uwn.User).OrderByDescending(uwn => uwn.NoteNo).Take(5).ToListAsync();
                return View(MainNote);
            }
        }

        public IActionResult LoginSuccess()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
