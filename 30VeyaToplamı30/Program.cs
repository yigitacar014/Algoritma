using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30VeyaToplamı30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToplaVeBul(20,10);
            Console.ReadLine();
       }
        static void ToplaVeBul(int x , int y)
        {
            if (x == 30 || y == 30)
            {
                Console.WriteLine("Bu sayılardan biri 30dur.");
            }
            if (x+y==30)
            {
                Console.WriteLine("Bu sayıların toplamı 30dur.");
            }
        }
    }
}
