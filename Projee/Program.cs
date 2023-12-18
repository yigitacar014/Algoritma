using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           // HarfAynı();
            //BuyukSayı();
            // YuzeYakın();
            //Karsılastırma();
            //YirmiİleOtuz();
            //Ytmetodu();

            Console.ReadLine();
//fsdafsadf
        }

        private static void Ytmetodu()
        {
            Console.Write("Lütfen bir kelime giriniz :");
            string kelime = Console.ReadLine();
            if (kelime.Contains("yt"))
            {
                Console.WriteLine(kelime.Remove(1, 2));
            }
            else
            {
                Console.WriteLine(kelime);
            }
        }

        private static void YirmiİleOtuz()
        {
            Console.Write("Lütfen bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen bir sayı giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            if (sayi >= 20 && sayi <= 30 && sayi1 >= 20 && sayi1 <= 30)
            {
                if (sayi >= sayi1)
                {
                    Console.WriteLine(sayi);
                }
                else { Console.WriteLine(sayi1); }
            }
            else if (sayi >= 20 && sayi1 <= 30)
            {
                Console.WriteLine(sayi);
            }
            else if (sayi1 >= 20 && sayi <= 30)
            {
                Console.WriteLine(sayi1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        private static void Karsılastırma()
        {
            Console.Write("Lütfen bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen bir sayı giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            if (sayi >= 40 && sayi <= 50 && sayi1 >= 40 && sayi1 <= 50 || sayi >= 50 && sayi <= 60 && sayi1 >= 50 && sayi1 <= 60)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        private static void YuzeYakın()
        {
            Console.Write("Lütfen bir sayı giriniz : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen bir sayı giriniz : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            if (number > number1)
            {
                Console.WriteLine("100 e en yakın olan sayı : " + number);
            }
            else if (number1 > number)
            {
                Console.WriteLine("100 e en yakın olan sayı : " + number1);
            }
            else if (number == number1)
            {
                Console.WriteLine(0);
            }
        }

        private static void BuyukSayı()
        {
            Console.Write("Birinci sayıyı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi > sayi1 && sayi > sayi2)
            {
                Console.WriteLine(sayi);
            }
            else if (sayi1 > sayi && sayi1 > sayi2)
            {
                Console.WriteLine(sayi1);
            }
            else
            {
                Console.WriteLine(sayi2);
            }
        }

        private static void HarfAynı()
        {

            Console.Write("Lütfen bir kelime giriniz :");
            string kelime = Console.ReadLine();
            var sonharf = kelime.Substring(kelime.Length-1);

            Console.WriteLine(sonharf+kelime+sonharf);

            Console.ReadLine();
        }
    }
}
