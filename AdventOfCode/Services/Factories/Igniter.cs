using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdventOfCode
{
    class Igniter
    {
        private Translator _translator = new Translator();
        private Object _ignite_;
        public Object Ignite(int day, int task)
        {
            switch (day)
            {
                case 1:
                    DayOne one = new DayOne();
                    _ignite_ = one.Run(task);
                    break;
                case 2:
                    DayTwo two = new DayTwo();
                    _ignite_ = two.Run(task);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Have not done this day / couldn't find it.");
                    break;

            }
            Console.WriteLine("||{0}\t || {1}\t || ", day, task);
            return _ignite_;
        }


    }
}
