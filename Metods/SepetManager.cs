using System;
using System.Collections.Generic;
using System.Text;

namespace Metods
{
    class SepetManager
    {
        public void Ekle(Product product)
        { 
            Console.WriteLine("Sepete Eklendi. : " + product.Adi); 
        }

        public void Ekle2(string urunAdi, string Aciklamasi, double FiyatBilgisi)
        {
            Console.WriteLine(urunAdi +"  " + Aciklamasi +"  " + FiyatBilgisi);
        }
    }
}
