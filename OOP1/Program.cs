using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategıryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategıryId = 5,
                UnitInStock = 5,
                UnitPrice = 5,
                ProductName = "Kalem"
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            productManager.Topla2(3, 6);
            //int sayi = 100;
            //productManager.Bisey(sayi);
            //Console.WriteLine(sayi);
            //Console.WriteLine(product1.ProductName);
        }
    }
}
