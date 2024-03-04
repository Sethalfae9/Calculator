using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorconsoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "aplikasi calculator";

            int a = 125; // declarasi variabel a, dg nilai awal 125;
            int b = 5; // declarasi variabel b, dg nilai awal 5;

            Console.WriteLine("hasil penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan sembarangan key umtuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
        // TODO: tambahkan method untuk perkalian dan pembagian
    }
}