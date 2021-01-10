using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nerdeBuAsalSayilar = 0;
            for (int sayi = 2; sayi <= 10000; sayi++)
            {
                int kontrol = 0;

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0) 
                    {
                        kontrol = 1;
                        break;
                    }
                }
                if (kontrol == 1)
                {
                    Console.WriteLine("{0} asal değidir", sayi);
                }
                else
                {
                    Console.WriteLine("{0} asaldır.", sayi);
                    nerdeBuAsalSayilar++;
                }
            }
            
            Console.ReadKey();

        }
    }
}
