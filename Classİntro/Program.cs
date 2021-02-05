using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs1= new Kurs();
            kurs1.egitmen = "beyza";
            kurs1.KursAdi = "java";
            kurs1.izlenmeOrani = 10000;
            Kurs kurs2 = new Kurs();
            kurs2.egitmen = "beyza";
            kurs2.KursAdi = "c#";
            kurs2.izlenmeOrani = 10005;
           
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.egitmen + ": " + kurs.KursAdi + ":" + kurs.izlenmeOrani );
            }

          
        }
    }
    class Kurs
    {
        public string KursAdi{ get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
