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
        public const string SessionKey_RightNumber = "_RightNumber";
        public const string SessionKey_Guesses = "_Guesses";

        [HttpGet]
        public IActionResult Index()
        {
            Random rnd = new Random();
            int RightNumber = 0;
            //a loop with 1-6 iterations to make the random number a "bit" more random
            for (int i = 0; i < rnd.Next(1, 7); i++)
            {
                RightNumber = rnd.Next(1, 101);
            }
            HttpContext.Session.SetString(SessionKey_RightNumber, RightNumber.ToString());

            return View();
        }
        [HttpPost]
        public IActionResult Index(int Guess)
        {
            HttpContext.Session.Get(SessionKey_RightNumber, SessionInfo_RightNumber);

            HttpContext.Session.SetString(SessionKey_RightNumber, SessionInfo_RightNumber);
        }
    }
}