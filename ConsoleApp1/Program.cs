using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** İsim doğrulama programı ***\n\n");
            Console.Write("sorgulamak istediğiniz ismi giriniz: ");
            string a = Console.ReadLine();
            if (a == "Mehmet")
            { Console.WriteLine("\naranan isim doğru"); }
            else
            {
                Console.WriteLine("\nbu isim bulunmamakta");
            }
            Console.Write("sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi < 0) { Console.WriteLine("sayınız negatif"); } //sıfır pozitif olsun
            else { Console.WriteLine("sayınız {0}pozitif", sayi); }

            Console.ReadLine();
        }
    }
}
