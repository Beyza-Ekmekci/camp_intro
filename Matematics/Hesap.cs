using System;
using System.Collections.Generic;
using System.Text;

namespace Matematics
{
    class Hesap
    {
       public void topla(int sayi1 , int sayi2)
        {
          double sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);

        }
        public void cikar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine(sonuc);

        }
        public void carpim(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine(sonuc);

        }

        public void böl(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine(sonuc);

        }

    }
}
