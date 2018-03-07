using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int g = 100; g < 201; g++)
            {
                int i = g % 7;
                if (i == 0)
                {
                    Console.WriteLine(g);
                }
            }
        }
    }
}
