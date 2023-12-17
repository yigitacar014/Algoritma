using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekraliDizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen birinci sayıyı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen ikinci sayıyı giriniz :");
            int number = Convert.ToInt32(Console.ReadLine());

            if (sayi<=20 && number>=50 || sayi<=20 && number>=50)
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
