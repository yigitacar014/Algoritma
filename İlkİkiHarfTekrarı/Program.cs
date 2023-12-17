using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İlkİkiHarfTekrarı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir kelime giriniz :");
            string kelime = Console.ReadLine();
            if (kelime.Length>=2)
            {
                           
               string yenikelime = kelime.Substring(0, 2) + kelime.Substring(0,2) + kelime.Substring(0, 2) + kelime.Substring(0, 2);
                Console.WriteLine(yenikelime);
                
            }
            else
            {
                Console.WriteLine(kelime);
            }
            Console.ReadLine();
        }
    }
}
