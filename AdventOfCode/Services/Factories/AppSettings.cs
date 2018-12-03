using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class AppSettings
    {
        bool executeMultipleTimes;
        int executeTimes = 2;

        public bool ExecuteMultipleTimes
        {
            get => executeMultipleTimes;
            set => executeMultipleTimes = value;
        }
        public int ExecuteTimes
        {
            get => executeTimes;
            set => executeTimes = value;
        }
    }
}
