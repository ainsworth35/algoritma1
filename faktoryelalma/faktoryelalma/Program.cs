using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoryelalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen faktoryeli alınacak sayıyı giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = 1; 
            for (int i = 1; i <= x; i++)
            {
                y *= i;
            }
            Console.WriteLine(x + "! = " + y  );
            Console.ReadKey();
        }
    }
}
