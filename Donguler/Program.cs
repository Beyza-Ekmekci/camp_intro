using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazilim Geliştirici kursu", "Programlamaya yeni baslayanlar için", "c# programlama kursu", "java kursu", "mobil programlama kursu" };
            
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i] );
            }

            foreach (string kurs  in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
