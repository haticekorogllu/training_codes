using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    double toplam = 0;
                    double ortalama = 0;
                    Console.Write("Buyrunuz istediğiniz sayıda dizi oluşturunuz  :");
                    int n = Int32.Parse(Console.ReadLine());
                    double[] dizi = new double[n];
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        Console.Write("Sayı {0}: ", i + 1);
                        dizi[i] = Convert.ToDouble(Console.ReadLine());
                        toplam += dizi[i];
                    }
                    ortalama = toplam / dizi.Length;
                    Console.WriteLine("Toplam : " + toplam);
                    Console.WriteLine("-------------------");
            
                    Console.WriteLine("Ortalama : " + ortalama);
                    Console.ReadKey();
                }
            }
        }
    }
}
