using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgeleSayiUretici = new Random();
            int uretilenSayi = rastgeleSayiUretici.Next(1, 100);
            bool sayiBulunduMu = false;
             
                
  
            
            
            while (!sayiBulunduMu )
            {

                Console.WriteLine("Tahmininizi Girin: ");
                int tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
                if (uretilenSayi > tahminEdilenSayi)
                {
                    Console.WriteLine(" Yukarı! ");
                }
                else if (uretilenSayi < tahminEdilenSayi)
                {
                    Console.WriteLine("Aşağı!");
                }
                else 
                {
                    Console.WriteLine("Eşittir!");
                  
                    Console.WriteLine("Tekrar Oynamak İster misin ? ");
                  
                   
                    int tekrarOyna = Convert.ToInt32(Console.ReadLine());
                    if( tekrarOyna==1 )
                    {
                        int sayUret = rastgeleSayiUretici.Next(1, 100);

                    } else
                    {
                        sayiBulunduMu = true;  
                    }
                   
                }
                 
            }
            
            Console.ReadLine();
            Console.ReadKey();
        }

    }
}
