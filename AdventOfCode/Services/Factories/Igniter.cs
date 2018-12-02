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
                    _ignite_ = one.run(task);
                    break;
                case 2:
                    DayTwo two = new DayTwo();
                    _ignite_ = two.run(task);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Have not done this day / couldn't find it.");
                    break;

            }
            Console.Write("{0} - Task {1} running -> ", _translator.Day(day), task);
            return _ignite_;
        }


    }
}
