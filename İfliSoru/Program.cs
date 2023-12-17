using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İfliSoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir kelime giriniz :");
            string kelime = Console.ReadLine();

            if (kelime.StartsWith("if"))
            {
                Console.WriteLine(kelime);
            }
            else
            {
                Console.WriteLine( "if "+ kelime);
            }
            Console.ReadLine();
        }
    }
}
