using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitexp
{
    class Program
    {
        static void Main(string[] args)
        {
            var history = new List<string>();
            history.Add("Initialize history list");

            history.ForEach(x => Console.WriteLine(x));
        }
    }
}
