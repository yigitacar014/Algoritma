using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarfSilme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HarfSil("Yiğit",2)); 

            Console.ReadLine();
        }
        public static string HarfSil(string isim , int x) 
        {
            return isim.Remove(x,1);
        }

        
    }
}
