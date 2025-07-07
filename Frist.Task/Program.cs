using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frist.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter the number of Small carpet :  ");
            int SmallCarpet = int.Parse(Console.ReadLine());

            Console.Write("enter the number of large carpet :  ");
            int LargeCarpet = int.Parse(Console.ReadLine());

            Console.WriteLine("the price of small carpet = $25 \n the price of large carpet = $35 ");

            double PSCarpet = SmallCarpet * 25;
            double PLCarpet = LargeCarpet * 35;

            double cost = PSCarpet + PLCarpet;
            double Tax = cost * 0.06;
            double total = cost + Tax;

            Console.WriteLine($"cost : ${cost} \n + Tax : ${Tax} ");
            Console.WriteLine($"total estimated : {total} \n This estimate is valid for 30 days");

        }
    }
}
