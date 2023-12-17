using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100ile200Arasında
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen bir sayı giriniz :");
            int sayi1= Convert.ToInt32(Console.ReadLine());
            if (sayi>=100 && sayi<=200 && sayi1>=100 && sayi1<=200 )
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
