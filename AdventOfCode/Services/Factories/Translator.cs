using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Translator
    {
        private readonly string prefix = "Day";
        private readonly string[] suffix = {"","One", "Two", "Three", "Four", "Five", "Six", "Seven" };
        public string Day(int day)
        {
            return (prefix + suffix[day]);
        }
        public string DayNumeric(int day)
        {
            return (prefix +" " + day);
        }

        public Translator(params int[] day)
        {
            Day(day.Sum());
        }

    }
}
