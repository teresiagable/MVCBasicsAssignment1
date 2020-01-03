using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasicsAssignment1.Models
{
    public class Health
    {
        public int BodyTemperature { get; set; }
        const int FEVER = 38;
        const int HYPOTHERMIA = 35;

        public static string CheckFever(Health theHealth)
        {
            if (theHealth.BodyTemperature > FEVER)
            { return "You might have fever. Cool down."; }
            else if (theHealth.BodyTemperature < HYPOTHERMIA)
            { return "You might have hypothermia. Drink something warm."; }
            else { return "Your temperature is ok"; }
        }
    }
}


