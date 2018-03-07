using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Random megagen = new Random();
            for (int i = 0; i < 51; i++)
            {
                int n = megagen.Next(0,51);
                Console.WriteLine(n);
                sum = sum + n;
                
            }
            
            Console.WriteLine("среднее арифметическое" + " " +  sum / 51);

        }
    }
}
