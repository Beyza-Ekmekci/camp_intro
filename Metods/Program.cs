using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Portakal";
            urun1.Fiyati = 1.50;
            urun1.Aciklama = "Antalya Portakalı";
            urun1.Id = 1;

            Product urun2 = new Product();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 2;
            urun2.Aciklama = "Bahar Çileği";
            urun2.Id = 2;

            Product urun3 = new Product();
            urun3.Adi = "Karpuz";
            urun3.Fiyati = 80;
            urun3.Aciklama = "Diyarbakır Karpuzu";
            urun3.Id = 3;

            Product[] meyveler = new Product[] { urun1, urun2, urun3 };

            foreach (var meyve in meyveler)
            {
                Console.WriteLine(meyve.Adi + "...... " +
                    meyve.Aciklama + "...... " 
                    + meyve.Fiyati + "...... " + 
                    meyve.Id);
            }

            Console.WriteLine("----------METODS-----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); // sayfa 1

            sepetManager.Ekle(urun2); // sayfa 2

            sepetManager.Ekle(urun3); // sayfa 3 

            sepetManager.Ekle2("Armut", "Yesil Armut", 10);
            sepetManager.Ekle2("Elma", "Yesil Elma", 16 );

        }
    }
}
