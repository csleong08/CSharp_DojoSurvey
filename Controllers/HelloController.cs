using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers     //namespace!
{
    public class HelloController : Controller   //inheritance
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("create")]
        public IActionResult Create(User myUser)
        {
            if(ModelState.IsValid)
            {
                return View("Result", myUser);
            }
            else
            {
                return View("Index");
            }
        }
    }
}