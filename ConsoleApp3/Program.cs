using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] rastgeleSayilar = new int[5];
            for ( int i = 0; i < rastgeleSayilar.Length; i++)
            {
                rastgeleSayilar[i] = random.Next(1, 5);
                Console.WriteLine(rastgeleSayilar[i]);
            }
            int puan1 = 0;
            int puan2 = 0;
            for ( int i = 0; i < rastgeleSayilar.Length; i++)
            {
                Console.WriteLine("1. Oyuncunun Tahmini: ");
                int tahmin1 = Convert.ToInt32(Console.ReadLine());
                if (tahmin1 == rastgeleSayilar[1])
                {
                    puan1+=10;
                }
                else
                {
                    if (rastgeleSayilar[i]> tahmin1)
                    {
                        puan1+=10 - (rastgeleSayilar[i] - tahmin1);
                    }
                    else
                    {
                        puan1+=10 - (tahmin1 - rastgeleSayilar[i]);
                    }
                    {
                        Console.Clear();
                        //*********************** 2. oyuncu başlangıcı
                        Console.WriteLine("2. Oyuncu Tahmini: ");
                        int tahmin2 = Convert.ToInt32(Console.ReadLine());  
                        if ( tahmin2 == rastgeleSayilar[i])
                        {
                            puan2 += 10;
                        }
                         else
                        {
                            if ( rastgeleSayilar[i] > tahmin2)
                            {
                                puan2 += 10 - (rastgeleSayilar[i] - tahmin2);
                            }
                            else
                            {
                                puan2 += 10 - (tahmin2 - rastgeleSayilar[i]);

                            }
                        }
                        Console.Clear();
                        Console.WriteLine("1.Oyuncunun Puanı: " + puan1);
                        Console.WriteLine("2.Oyuncunun Puanı: " + puan2);
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
