using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Ve7Katları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 3 == 0 || sayi % 7 == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.ReadLine();
        }
    }
}

