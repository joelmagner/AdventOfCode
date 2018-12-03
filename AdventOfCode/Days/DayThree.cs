using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class DayThree
    {

        private readonly FileManager _fileManager = new FileManager();
        public Object DayThreeTaskOne()
        {
            var file = _fileManager.ReadFromFileToList<string>(3);
            var overlap = new Dictionary<Tuple<int, int>, List<int>>();
            foreach (string line in file)
            {
                var input = line.Split(new[] { '#', '@', ',', ':', 'x', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                int id = input[0],
                xInit = input[1],
                yInit = input[2],
                width = input[3],
                height = input[4],
                yRange = input[2] + input[4],
                xRange = input[1] + input[3];
                for (int x = xInit; x < xRange; x++)
                {
                    for (int y = yInit; y < yRange; y++)
                    {
                        if (!overlap.ContainsKey(new Tuple<int, int>(x, y)))
                        {
                            overlap.Add(new Tuple<int, int>(x, y), new List<int>());
                        }
                        overlap[new Tuple<int, int>(x, y)].Add(id);
                    }
                }
            }
            return overlap.Count(x => x.Value.Count > 1);
        }


        public Object DayThreeTaskTwo()
        {
            var file = _fileManager.ReadFromFileToList<string>(3);
            var data = _fileManager.ReadFromFile(3);
            var overlap = new Dictionary<Tuple<int, int>, List<int>>();
            foreach (string line in file)
            {
                var input = line.Split(new[] { '#', '@', ',', ':', 'x', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                int id = input[0],
                xInit = input[1],
                yInit = input[2],
                width = input[3],
                height = input[4],
                yRange = input[2] + input[4],
                xRange = input[1] + input[3];
                for (int x = xInit; x < xRange; x++)
                {
                    for (int y = yInit; y < yRange; y++)
                    {
                        if (!overlap.ContainsKey(new Tuple<int, int>(x, y)))
                        {
                            overlap.Add(new Tuple<int, int>(x, y), new List<int>());
                        }
                        overlap[new Tuple<int, int>(x, y)].Add(id);
                    }
                }

            }

            var unique = overlap.Where(e => e.Value.Count > 1).SelectMany(e => e.Value);
            unique = unique.Distinct().ToList();
            return Enumerable.Range(1, data.Length).FirstOrDefault(item => !unique.Contains(item));
        }




        public Object Run(int task)
        {
            return task == 1 ? DayThreeTaskOne() : task == 2 ? DayThreeTaskTwo() : "404";
        }
    }
}
