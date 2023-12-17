using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_VarmıYokmu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir kelime giriniz :");
            string kelime = Console.ReadLine();
            if (kelime.StartsWith("C#"))
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
