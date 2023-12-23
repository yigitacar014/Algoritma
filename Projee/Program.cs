using System;
using System.Collections.Generic;
using System.IO;
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
            //zBulma();
            // SonBasamakAynı();
           // Tekrar();

            Console.ReadLine();

        }

        private static void Tekrar()
        {
            Console.Write("Lütfen bir Kelime Giriniz :");
            string kelime = Console.ReadLine();
            Console.Write("Lütfen kaç kere yazacağınızı söyleyin :");
            int secenek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < secenek; i++)
            {
                Console.Write(kelime);

            }
        }

        private static void SonBasamakAynı()
        {
            Console.Write("Lütfen bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen bir sayı giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            string metinecevir = sayi.ToString();
            string metinecivo = sayi1.ToString();
            if (sayi > 0 && sayi1 > 0 && metinecevir[metinecevir.Length - 1] == metinecivo[metinecivo.Length - 1])
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        private static void zBulma()
        {
            Console.Write("Lütfen bir kelime  giriniz :");
            string word = Console.ReadLine();
            int asd = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'z')
                {
                    asd++;
                }
            }
            if (asd > 1 && asd <= 4)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
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
