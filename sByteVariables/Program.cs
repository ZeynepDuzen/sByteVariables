using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sByteVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sbyte number;
            //number = 121;
            //Console.WriteLine(number);

            //sbyte sayi;
            //Console.WriteLine("Lütfen bir sayi giriniz : ");
            //Console.WriteLine();
            //sayi = Convert.ToSByte(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Girmis oldugunuz sayi : " + sayi);

            //Klavyeden SByte değerinde girilen 2 sayiyi toplayan kod blogu
            sbyte sayi1, sayi2, toplam;
            Console.WriteLine("Lütfen toplanmasını istediginiz iki sayidan birincisini giriniz : ");
            Console.WriteLine();
            sayi1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("İkinci sayıyı giriniz : ");
            Console.WriteLine();
            sayi2 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine();
            toplam = Convert.ToSByte(sayi1 + sayi2);
            Console.WriteLine("Girmis oldugunuz sayilarin toplami : " + toplam);



            Console.Read();
        }
    }
}
