using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            int num1 = 0; int num2 = 0; int menu;

            Console.WriteLine("Calculator");


            Console.WriteLine("Pilih menu calculator");
            Console.WriteLine("\t1 - pertambahan");
            Console.WriteLine("\t2 - pengurangan");
            Console.WriteLine("\t3 - Perkalian");
            Console.WriteLine("\t4 - Pembagian");
            Console.Write("Input menu calculator ");
            menu = int.Parse(Console.ReadLine());


            Console.WriteLine();
            
            Console.Write("Inputkan nilai a = ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inputkan nilai b = ");
            num2 = Convert.ToInt32(Console.ReadLine());


            switch (menu)
            {
                case 1:
                    Console.WriteLine($"Hasil: {num1} + {num2} = " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine($"Hasil: {num1} - {num2} = " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine($"Hasil: {num1} * {num2} = " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine($"Hasil: {num1} / {num2} = " + (num1 / num2));
                    break;

                default:
                    Console.WriteLine("Error");
                    break;


            }

            Console.Write("Tekan tombol apapun untuk keluar aplikasi");
            Console.ReadKey();
        }

       

    }
}
