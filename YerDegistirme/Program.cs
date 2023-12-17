using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YerDegistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir kelime yazınız :");
            string kelime = Console.ReadLine();
            for (int i = kelime.Length-1; i>=0; i--)
            {
                Console.Write(kelime[i]);
            }
            Console.WriteLine();
        }
       
        }
    }

