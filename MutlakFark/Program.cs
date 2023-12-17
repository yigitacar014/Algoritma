using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutlakFark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz :");
            int n = Convert.ToInt32(Console.ReadLine());
            if (51>n)
            {
                int fark = 51 - n;
                Console.WriteLine("İki sayının farkı :" + fark);
            }
            else
            {
                int mutlakfark = (n-51)*3;
                Console.WriteLine("İki sayının farkının 3 katı : " + mutlakfark);
            }
            Console.ReadLine();
        }
    }
}
