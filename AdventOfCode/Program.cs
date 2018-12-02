using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSettings _appSettings = new AppSettings();
            Igniter _ignite_ = new Igniter();

            Console.WriteLine("=== Advent Of Code {0} ===", DateTime.Now.Year);
            Console.WriteLine("Result: {0}", _ignite_.Ignite(1, 1));
            Console.WriteLine("Result: {0}", _ignite_.Ignite(1, 2));
            Console.WriteLine("Result: {0}", _ignite_.Ignite(2, 1));
            Console.WriteLine("Result: {0}", _ignite_.Ignite(2, 2));
            Console.WriteLine("Done");
            Console.ReadLine();
            return;
            
        }
    }
}
