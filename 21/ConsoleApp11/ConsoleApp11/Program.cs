using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи рост бояр до 20");
            int alive = 0;
            int kill = 0;
            for (int i = 0;i<20;i++)
            {
                int g = int.Parse(Console.ReadLine());
                
                if (g>160)
                {
                    kill++;
                    Console.WriteLine("еще 1 казнили");
                }
                else
                {
                    alive++;
                    Console.WriteLine("+1 живой");
                }
                Console.WriteLine("Выжило" +" " + alive);
                Console.WriteLine("Казнили" + " " + kill);
            }
            

        }
    }
}
