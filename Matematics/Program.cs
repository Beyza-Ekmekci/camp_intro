using System;

namespace Matematics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Hesap hesap = new Hesap();
            hesap.carpim(10,20);
            Console.WriteLine("------------");
            hesap.cikar(10, 20);
            Console.WriteLine("-------------");
            hesap.böl(10, 20);
            Console.WriteLine("--------------");
            hesap.topla(10, 20);
          
        }
    }
}
