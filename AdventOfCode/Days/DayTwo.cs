using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class DayTwo
    {
        private readonly FileManager _fileManager = new FileManager();

        public Object DayTwoTaskOne()
        {
            List<string> data = _fileManager.ReadFromFileToList<string>(2);
            int twos = Occurrences(data, 2),
            threes = Occurrences(data, 3);
            return twos*threes;
        }

        public int Occurrences(List<string> words, int number)
        {
            return words.Count(id => id.GroupBy(c => c).Any(g => g.Count() == number));
        }

        public Object DayTwoTaskTwo()
        {
            List<string> data = _fileManager.ReadFromFileToList<string>(2);
            foreach (string entry in data)
            {
                var pair = data.Select(id => id.Remove(data.FindIndex(x => x == entry), 1))
                           .GroupBy(id => id)
                           .FirstOrDefault(g => g.Count() > 1);
                if(pair != null)
                {
                    return pair?.First();
                }
            }
            return "Didn't find anything :(";
        }

        public Object Run(int task)
        {
            return task == 1 ? DayTwoTaskOne() : task == 2 ? DayTwoTaskTwo() : "404";
        }
    }
}
