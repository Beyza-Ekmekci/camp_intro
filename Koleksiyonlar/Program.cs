﻿using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Beyza", "Emine","Murat","Betül"};
            //Console.WriteLine(isimler [0]);

            List<string> isimler2 = new List<string>{"Engin", "Emine", "Aslı", "Can"};
            
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Beyza");
            Console.WriteLine( isimler2[4]);
         
        }
    }
}
