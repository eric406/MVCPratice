using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPratice.Controllers
{
    public class ErrorHandlerController: Controller
    {   
        [TempData]
        public string Message { get; set; }
        public IActionResult ErrorMessage()
        {
             if (!TempData.ContainsKey("ErrorMessage"))
            {

            return new EmptyResult();

            }
            //保留TempData資料，不要清除
            TempData.Keep("ErrorMessage");
            return View();
        }
    }
}
