using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfEkle("else");
            Console.ReadLine();
        }
        static void IfEkle(string isim)
        {
            if (isim=="if" + isim)
            {
                Console.WriteLine(isim);

            }
            else
            {
                string yenisim = "if " + isim;
                Console.WriteLine(yenisim);
            }
        }

        }

    }

