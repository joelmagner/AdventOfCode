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
            int twos=0, threes=0;
            List<string> data = _fileManager.ReadFromFileToList<string>(2);

            twos = occurrences(data, 2);
            threes = occurrences(data, 3);

            return twos*threes;
        }

        public int occurrences(List<string> words, int number)
        {
            return words.Count(id => id.GroupBy(c => c).Any(g => g.Count() == number));
        }

        public Object DayTwoTaskTwo()
        {
            List<string> data = _fileManager.ReadFromFileToList<string>(2);
            IGrouping<string, string> pair;
            foreach (string entry in data)
            {
                pair = data.Select(id => id.Remove(data.FindIndex(x => x == entry), 1))
                           .GroupBy(id => id)
                           .FirstOrDefault(g => g.Count() > 1);

                if (pair != null)
                {
                    return pair.First();
                }
            }
            return "Didn't find anything :(";
        }

        public Object run(int day)
        {
            return day == 1 ? DayTwoTaskOne() : day == 2 ? DayTwoTaskTwo() : "404";
        }
    }
}
