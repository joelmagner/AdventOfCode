using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
namespace AdventOfCode.DayOne
{
    class AdventOfCodeDayOne
    {
        private int result = 0, duplicate;
        private List<int> history = new List<int> {};

        private bool GetInput()
        {
            AdventOfCodeDayOne dayOne = new AdventOfCodeDayOne();
            try
            {
                bool calibrated = false;
                history.Add(result);
                while(duplicate == 0)
                {
                    string[] inputs = System.IO.File.ReadAllLines(@"C:\Users\Joel\source\repos\joelmagner\AdventOfCode\AdventOfCode.DayOne\inputDayOne.txt");
                    var last = inputs.Last();
                    foreach (string input in inputs)
                    {
                        result = dayOne.ChronalCalibration(Int32.Parse(input));
                        if(input == last && !calibrated){Console.WriteLine("Task A: {0}", result); calibrated = true;}
                        duplicate = dayOne.Duplicate(result) == true ? result : 0;
                    }
                }
                return false;
            }
            catch(Exception e)
            {
                Console.WriteLine("e:", e);
                return false;
            }
        }

        private bool Duplicate(int result)
        {

            if(history.Contains(result)){
               Console.WriteLine("Task B: {0}",result);
               return true;
            }
            history.Add(result);
            return false;
        }

        private int ChronalCalibration(int freq)
        {
            return result += freq;
        }
     
        static int Main(string[] args)
        {
            AdventOfCodeDayOne dayOne = new AdventOfCodeDayOne();

  
            return dayOne.result = dayOne.GetInput() ? dayOne.result : 0;
        }
    }
}
