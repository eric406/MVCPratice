using Microsoft.AspNetCore.Mvc;
using MVCPratice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPratice.Controllers
{
    public class RazorScoresController : Controller
    {
        protected List<Student> students = new List<Student>()
        {
            new Student(){ Id = 1, Name = "小明" , Chinese = 80, English = 100, Math = 60},
            new Student(){ Id = 1, Name = "小黑" , Chinese = 70, English = 88, Math = 99},
            new Student(){ Id = 1, Name = "小白" , Chinese = 85, English = 90, Math = 80},
            new Student(){ Id = 1, Name = "超超" , Chinese = 100, English = 60, Math = 70},
            new Student(){ Id = 1, Name = "小翔" , Chinese = 80, English = 100, Math = 65},
        };
        public IActionResult Index()
        {
            return View(students);
        }
        public IActionResult ScoresRazor()
        {
            students.ForEach(x => x.Total = x.Chinese + x.English + x.Math);
            //Find Top total student's ID
            int topId = students.OrderByDescending(x => x.Total).Select(x => x.Id).FirstOrDefault(); ;
            ViewData["TopId"] = topId;
            return View(students);
        }
    }
}
