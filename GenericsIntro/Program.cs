using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylist<string> names = new Mylist<string>();
            names.Add("Raşit");

            List<string> list = new List<string>();
            Console.WriteLine(list.Count);


        }
    }
}
