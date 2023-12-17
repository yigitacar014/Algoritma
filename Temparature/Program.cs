using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temparature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen birinci dereceyi giriniz : ");
            int derece = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen ikinci dereceyi giriniz :");
            int derece1 = Convert.ToInt32(Console.ReadLine());

            if (derece<=0 && derece1>=100 || derece1<=0 && derece1>=100)
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
