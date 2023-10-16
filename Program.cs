using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ödevvvv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            login();
        }



        public static void signin(out string ad,out string eposta, out string sifre)
        {
            Console.WriteLine("---------------KAYIT OL---------------");
            Console.Write("Ad: ");
            ad = Console.ReadLine();
            Console.Write("Soyad: ");
            string soyad = Console.ReadLine();
            Console.Write("E-posta: ");
            eposta = Console.ReadLine();
            Console.Write("Şifre: ");
            sifre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Başarıyla kayıt oldunuz.Giriş sayfasına yönlendiriliyorsunuz...");
            Thread.Sleep(2400);
            Console.Clear();
        }

        public static void login()
        {
            string ad;
            string eposta;
            string sifre;
            int hak = 2;
            signin(out ad,out eposta, out sifre);
            
            while (true)
            {
                Console.WriteLine("---------------GİRİŞ YAP---------------");
                Console.Write("E-posta: ");
                string eposta1 = Console.ReadLine();
                Console.Write("Şifre: ");
                string sifre1 = Console.ReadLine();


                if (eposta == eposta1 && sifre == sifre1)
                {
                    for (int i = 0; i < ad.Length; i++)
                    {
                        Console.WriteLine(ad[i]);
                    }
                    Console.WriteLine("Giriş İşlemi Başarılı.");
                    break;
                }
               else
                {
                    
                    if (hak == 0)
                    {
                        Console.Clear();
                        string a = "HESABINIZ BLOKE OLDU";
                        for (int i = a.Length-1; i>=0 ; i--)
                        {
                            Console.WriteLine(a[i]);
                        }
                        Thread.Sleep(2000);
                        break;

                    }
                    if (hak > 0)
                    {
                        Console.WriteLine("Eposta veya Şifre yanlış. Tekrar Deneyiniz.");
                        Thread.Sleep(1800);
                        Console.Clear();
                        hak -= 1;

                    }


                }
               
            }
        }
    }
}