using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen birinci sayıyı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen ikinci sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            if (sayi==sayi1)
            {
                int toplama = (sayi + sayi1) * 3;
                Console.WriteLine("Bu sayının toplamının üç katı : " + toplama);
            }
            else
            {
                int toplama1 = sayi + sayi1;
                Console.WriteLine("Bu iki sayının toplamı : "+ toplama1);
            }
            Console.ReadLine();

        }
    }
}
