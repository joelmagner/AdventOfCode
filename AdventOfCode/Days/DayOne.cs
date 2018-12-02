using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class DayOne
    {
        private readonly FileManager _fileManager = new FileManager();

        public Object DayOneTaskOne()
        {
            int result = 0;
            List<int> data = _fileManager.ReadFromFileToList<int>(1);

            foreach (int item in data)
            {
                result += item;
            }
            return result;
        }

        public Object DayOneTaskTwo()
        {
            int result = 0;
            List<int> data = _fileManager.ReadFromFileToList<int>(1);
            List<int> history = new List<int>();
            bool duplicate = false;
            while (!duplicate)
            {
                foreach (int item in data)
                {
                    result += item;
                    if (history.Contains(result))
                        duplicate = true;

                    history.Add(result);
                }
            }
            return result;
        }

        public Object run(int day)
        {
            return day == 1 ? DayOneTaskOne() : day == 2 ? DayOneTaskTwo() : 404;
        }
    }
}
