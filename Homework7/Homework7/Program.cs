using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {     // hocam index no bulamadım bir türlü :/ 
        static void Main(string[] args)
        {
            string [] yemekler = { " içlikofte", "cigkofte", "kebap", "dolma", "lahmacun", "pide", "döner" };
            Console.WriteLine(" Canın ne çekiyor ?");
            string girilenYemek = Console.ReadLine();
            bool varMi = false;
            
            
             foreach (string yemek in yemekler )
            {
                Console.WriteLine(yemek + "-");
                   
                if( girilenYemek = yemekler)
                {
                    varMi = true;
                    break;

                }
            }
            Console.WriteLine();
            if (varMi)
            {
                Console.WriteLine($"{girilenYemek} arrayde vardır.");
                
            }
            else
            {
                Console.WriteLine($"{girilenYemek} arrayde yoktur.");

            }
            
        }
    }
}
