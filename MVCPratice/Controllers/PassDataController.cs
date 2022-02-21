
using Microsoft.AspNetCore.Mvc;
using MVCPratice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPratice.Controllers
{
    public class PassDataController : Controller
    {

        public List<Employee> empsList { get; } = new List<Employee>
        {
            new Employee { Id = 10001, Name = "David", Phone = "0933-154228", Email ="david@gmail.com" },
            new Employee { Id = 10002, Name = "Mary", Phone = "0925-157886", Email ="mary@gmail.com" },
            new Employee { Id = 10003, Name = "John", Phone = "0921-335884", Email ="john@gmail.com" },
            new Employee { Id = 10004, Name = "Cindy", Phone = "0971-628322", Email ="cindy@gmail.com" },
            new Employee { Id = 10005, Name = "Rose", Phone = "0933-154228",  Email ="rose@gmail.com" }
        };


        public IActionResult Index()
        {
            //ViewData["Name"] = "Kevin";
            //ViewData["Age"] = 33;
            //ViewData["Single"] = "True";
            //ViewData["Employees"] = empsList;   //儲存model集合物件

          

            return View(empsList);
        }
        public IActionResult PassViewBag()
        {
         
            ViewBag.Nickname = "Mary";
            ViewBag.Height = 168;
            ViewBag.Weight = 52;
            ViewBag.Married = false;


            return View();
        }

        public IActionResult PetShop()
        {
            ViewBag.Address = "台北市大安區羅斯福路100號";
            ViewData["Company"] = "貓貓狗狗寵物店";

            List<string> petList = new List<string>();
            petList.Add("狗");
            petList.Add("貓");
            petList.Add("鼠");
            petList.Add("鳥");
            petList.Add("烏龜");
            

            return View(petList);

        }
        public IActionResult PassTempData()
        {
            TempData["ErrorMessage"] = "發生錯誤，請聯絡系統管理人員";
            TempData["Time"] = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            TempData["User"] = "Eric";
            
            return RedirectToAction("ErrorMessage", "ErrorHandler");

        }
    }
}
