using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Temsilciler_Console_29_12_21
{
    internal class Program
    {
        /*---DELEGATE - TEMSİLCİLER
         * Aynı method imzasına sahip olan methodları tutan ve liste içerisinde barındıran yapılardır.
         * Method tutucu olarakta bilinir.
         * Method imzası : Hangi parametre alıyor, ne dönüyor buna bakar.
         */

        delegate void MathIslem(int s1, int s2);


        static void Topla(int s1, int s2)
        {
            Console.WriteLine($"Toplama işlemi sonucu: {s1 + s2}");
        }
        static void Cikar(int s1, int s2)
        {
            Console.WriteLine($"Çıkarma işlemi sonucu: {s1 - s2}");
        }
        static void Carp(int s1, int s2)
        {
            Console.WriteLine($"Çarpma işlemi sonucu: {s1 * s2}");
        }
        static void Bol(int s1, int s2)
        {
            Console.WriteLine($"Bölme işlemi sonucu: {s1 / s2}");
        }
        static void Main(string[] args)
        {
            //Topla(45,33);
            //Cikar(40, 22);
            //Carp(7, 9);
            //Bol(81,9);

            MathIslem m1 = new MathIslem(Topla);
            m1 += Cikar;
            m1 += Carp;
            m1 += Bol;

            m1.Invoke(30, 2); //Delegate icerisine girdiğimiz methodları bu değerler ile çalıştırır

            Console.WriteLine(" ");
            Delegate [] isaretedilenmethodlar = m1.GetInvocationList();
             
            foreach(var item in isaretedilenmethodlar)
            {
                Console.WriteLine(item.Method.Name);
            }
            Console.WriteLine(" ");
            m1 -= Carp;
            foreach (var item in m1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
}
