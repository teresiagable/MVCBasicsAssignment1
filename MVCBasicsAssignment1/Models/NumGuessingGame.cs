using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasicsAssignment1.Models
{
    public class NumGuessingGame
    {

        public const string SessionKey_RightNumber = "_Number";
        public const string SessionKey_Guesses = "_Guesses";
        public int SessionInfo_RightNumber { get; private set; }
        public List<int> SessionInfo_Guesses { get; private set; }

        public NumGuessingGame()
        {
            Random rnd = new Random();

            //a loop with 1-6 iterations to make the random number a bit more random
            for (int i = 0; i < rnd.Next(1, 7); i++)
            {
                SessionInfo_RightNumber = rnd.Next(1, 101);
            }
            HttpContext.Session.SetString(SessionKey_RightNumber, SessionInfo_RightNumber);
        }

        public List<int> NewGuess(int Guess)
        {
            HttpContext.Session.Get(SessionKey_RightNumber, SessionInfo_RightNumber);

            HttpContext.Session.SetString(SessionKey_RightNumber, SessionInfo_RightNumber);
        }
    }
}
