using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework33
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sayilar = new int[5] { 78, 65, 12, -13, 7 };
            Console.Write("Dizinin ilk hali: ");
            int gecici;
            foreach (int deger in sayilar)
            {
                Console.Write(deger + " ");
            }
            for (int i = 0; i < sayilar.Length - 1; i++)
            {
                for (int j = i; j < sayilar.Length; j++)
                {
                   
                    if (sayilar[i] > sayilar[j])
                    {
                        gecici = sayilar[j];
                        sayilar[j] = sayilar[i];
                        sayilar[i] = gecici;
                    }

                }

            }
            Console.WriteLine();
            Console.Write("Dizinin son hali: ");
            foreach (int deger in sayilar)
            {
                Console.Write(deger + " ");

            }
            Console.ReadKey();
        }
    }
}
