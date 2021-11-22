using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCPratice.Models.HtmlHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPratice.Controllers
{
    public class HtmlHelpersController : Controller
    {
        // GET: HtmlHelpersController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SampleHelpers()
        {
            User register = new User()
            {
                Id = 1001,
                Name = "王曉明",
                Nickname = "小明",
                Email = "Ming@gmail.com",
                City = 2,
                Terms = true
            };
            ViewData.Model = register;
            return View();
        }

    }
}
