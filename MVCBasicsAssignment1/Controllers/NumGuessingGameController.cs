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
        //public const string SessionKey_Guesses = "_Guesses";

        [HttpGet]
        public IActionResult Index()
        {
            Random rnd = new Random();
            int rightNumber = 0;
            //a loop with 1-6 iterations to make the random number a "bit" more random
            for (int i = 0; i < rnd.Next(1, 7); i++)
            {
                rightNumber = rnd.Next(1, 101);
            }
            HttpContext.Session.SetInt32(SessionKey_RightNumber, rightNumber);
            ViewBag.GuessResult = rightNumber;
            return View();
        }
        [HttpPost]
        public IActionResult Index(int guess)
        {
            int? rightNum = HttpContext.Session.GetInt32(SessionKey_RightNumber);
            string returnValue;


            if (guess == rightNum)
            { returnValue = "Your guess " + guess + " is correct! " + rightNum; }
            else
            {
                if (guess < rightNum)
                { returnValue = "Your guess " + guess + " is to low. " + rightNum; }
                else returnValue = "Your guess " + guess + " is to high. " + rightNum;
            }

            ViewBag.GuessResult = returnValue;

            return View();
        }
    }
}