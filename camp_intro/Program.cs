using System;

namespace camp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int sayi = 320000;
            double faizOrani = 1.45;
            bool SistemeGirisYaptıMi = false;
            if (SistemeGirisYaptıMi == true)
            {
                Console.WriteLine("Sisteme giriş yapıldı");

            }
            else
            {
                Console.WriteLine("Lütfen giriş yapınız");

            }
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
