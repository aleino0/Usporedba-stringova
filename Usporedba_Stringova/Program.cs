using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usporedba_Stringova
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst1 = "Ovo je neki tekst.";
            string tekst2 = "Ovo je NEKI tekst.";
            string tekst3 = "ovo je neki tekst.";
            string tekst4 = "Ovo je neki tekst.";

            //korištenje bool varijable
            //različiti tekstovi
            if (tekst1==tekst2)
            {
                Console.WriteLine("Ovi tekstovi su jednaki");
            }
            else
            {
                Console.WriteLine("Ovi tekstovi nisu jednaki");
            }

            if (tekst1 == tekst3)
            {
                Console.WriteLine("Ovi tekstovi su jednaki");
            }
            else
            {
                Console.WriteLine("Ovi tekstovi nisu jednaki");
            }

            //isti tekst
            if (tekst1 == tekst4)
            {
                Console.WriteLine("Ovi tekstovi su jednaki");
            }
            else
            {
                Console.WriteLine("Ovi tekstovi nisu jednaki");
            }

            //korištenje compare staticke metode
            if (string.Compare(tekst1, tekst2) == 0)
            {
                Console.WriteLine("Ovi tekstovi su jednaki");
            }
            else
            {
                Console.WriteLine("Ovi tekstovi nisu jednaki");
            }

            if (string.Compare(tekst1, tekst3) == 0)
            {
                Console.WriteLine("Ovi tekstovi su jednaki");
            }
            else
            {
                Console.WriteLine("Ovi tekstovi nisu jednaki");
            }

            //isti tekst
            if (string.Compare(tekst1, tekst4) == 0)
            {
                Console.WriteLine("Ovi tekstovi su jednaki");
            }
            else
            {
                Console.WriteLine("Ovi tekstovi nisu jednaki");
            }

            Console.ReadKey();
        }
    }
}
