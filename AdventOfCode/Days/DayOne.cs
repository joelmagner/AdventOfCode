﻿using System;
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
                    {
                        duplicate = true;
                        break;
                    }
                    history.Add(result);
                }
            }
            return result;
        }

        public Object Run(int task)
        {
            return task == 1 ? DayOneTaskOne() : task == 2 ? DayOneTaskTwo() : 404;
        }
    }
}
