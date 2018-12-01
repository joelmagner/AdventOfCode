using System;

namespace AdventOfCode.DayOne
{
    class AdventOfCodeDayOne
    {
        private int result = 0;
        private bool GetInput()
        {
            AdventOfCodeDayOne dayOne = new AdventOfCodeDayOne();
            try
            {
                string[] inputs = System.IO.File.ReadAllLines(@"C:\AdventOfCode\AdventOfCode.DayOne\inputDayOne.txt");
                foreach (string input in inputs)
                {
                    result = dayOne.ChronalCalibration(Int32.Parse(input));
                }
                return true; 
            }
            catch(Exception e)
            {
                Console.WriteLine("e:", e);
                return false;
            }
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
