using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCBasicsAssignment1.Controllers
{
    public class NumGuessingGameController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.GetString
            return View();
        }
    }
}