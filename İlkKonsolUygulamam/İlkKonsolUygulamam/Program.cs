using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace İlkKonsolUygulamam
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz.");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen başka bir sayı daha giriniz.");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Girdiğiniz sayıların toplamı: ");
            Console.WriteLine(x + y);
            Console.Write("Girdiğiniz sayıların kalanı: ");
            Console.WriteLine(x - y);
            Console.Write("Girdiğiniz sayıların çarpımı: ");
            Console.WriteLine(x * y);
            Console.Write("Girdiğiniz sayıların bölümü: ");
            Console.WriteLine(x / y);
            Console.Write("Girdiğiniz sayıların modu: ");
            Console.WriteLine(x % y);


            Console.ReadKey();
        }
    }
}
