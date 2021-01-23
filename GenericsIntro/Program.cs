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

            Console.WriteLine(names.Length);

            names.Add("Arif");

            Console.WriteLine(names.Length);

            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
