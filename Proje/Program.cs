using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(KontolEt(25)); 
            Console.ReadLine();
        }
        static bool KontolEt(int x)
        {
            if (Math.Abs(x - 100) <= 10 || Math.Abs(x - 200) <= 10)
                   return true;

            return false;
        }
    }
}
