using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Translator
    {
        
        public string Day(int day)
        {
            string prefix = "Day", translatedDay = "";
            string[] suffix = {"","One", "Two", "Three", "Four", "Five", "Six", "Seven" };
            return (translatedDay = prefix + suffix[day]);
        }

        public Translator(params int[] day)
        {
            Day(day.Sum());
        }

    }
}
