﻿using System;
using System.Collections.Generic;

namespace Colactions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Raşit", "Ahmet", "Enes", "Rukiye" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            names = new string[5];
            names[4] = "Yasemin";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);

            List<string> names2 = new List<string> { "Rukiye", "Enes", "Ahmet", "Raşit" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Yasemin");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
        }
    }
}
