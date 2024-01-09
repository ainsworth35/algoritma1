using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltÜstSayı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Alt sayıyı giriniz");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Üst sayıyı giriniz.");
            //double y = Convert.ToDouble(Console.ReadLine());
            //double sonuc = Math.Pow(x, y);
            //Console.WriteLine(sonuc);

            double sonuc = 1;
            Console.Write("Taban sayıyı giriniz: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üs sayıyı giriniz: ");
            double y = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= y; i++)
            {
                sonuc = sonuc * x;
            }
            Console.WriteLine("{0}^{1}={2}", x, y, sonuc);




            Console.ReadKey();
        }
    }
}
