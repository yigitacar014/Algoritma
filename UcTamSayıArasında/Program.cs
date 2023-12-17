using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcTamSayıArasında
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayıyı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sayıyı giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi>=20 && sayi<=50 || sayi1>=20 && sayi1<=50 || sayi2>=20 && sayi2<=50)
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
