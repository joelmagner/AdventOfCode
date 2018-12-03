using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdventOfCode
{
    class Igniter
    {
        private Object _ignite_;
        public Object Ignite(int day, int task)
        {
            switch (day)
            {
                case 1:
                    var one = new DayOne();
                    _ignite_ = one.Run(task);
                    break;
                case 2:
                    var two = new DayTwo();
                    _ignite_ = two.Run(task);
                    break;
                case 3:
                    var three = new DayThree();
                    _ignite_ = three.Run(task);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Have not done this day / couldn't find it.");
                    break;

            }
            Console.Write("||{0,4}\t ||  {1,1}\t || ", day, task);
            return _ignite_;
        }


    }
}
