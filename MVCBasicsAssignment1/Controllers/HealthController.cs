using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCBasicsAssignment1.Controllers
{
    public class HealthController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(MVCBasicsAssignment1.Models.Health health)
        {
            ViewBag.FeverResponse = MVCBasicsAssignment1.Models.Health.CheckFever(health);

            return View();
        }
    }
}