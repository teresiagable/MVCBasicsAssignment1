using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasicsAssignment1.Models
{
    public class NumGuessingGame
    {

        public List<int> SessionInfo_Guesses { get; private set; }

        public NumGuessingGame()
        {
        }


    }
}
