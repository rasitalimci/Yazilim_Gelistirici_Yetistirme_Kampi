using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.FirstName = "Raşit";
            customer1.LastName = "ALIMCI";
            customer1.TcNo = "11111111111";

            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "123456";
            customer2.CompanyName = "ALIMCI HOLDİNG";
            customer2.TaxNo = "2222222222";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);


        }
    }
}
