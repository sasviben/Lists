using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Customer
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public int Placa { get; set; }
        public string Tip { get; set; }
    }
     class CustomerSaving
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 10,
                Ime = "Sandro",
                Placa = 6000,
                Tip = "RetailCustomer"
            };

            Customer customer2 = new Customer()
            {
                ID = 11,
                Ime = "Filip",
                Placa = 9000,
                Tip = "RetailCustomer"
            };

            Customer customer3 = new Customer()
            {
                ID = 12,
                Ime = "Hrvoje",
                Placa = 15000,
                Tip = "RetailCustomer"
            };
            Customer customer4 = new Customer()
            {
                ID = 13,
                Ime = "Vlado",
                Placa = 25000,
                Tip = "CorporateCustomer"
            };
            Customer customer5 = new Customer()
            {
                ID = 14,
                Ime = "Snježana",
                Placa = 2500,
                Tip = "CorporateCustomer"
            };
            List<Customer> listRetailCustomers = new List<Customer>();
            listRetailCustomers.Add(customer1);
            listRetailCustomers.Add(customer2);
            listRetailCustomers.Add(customer3);


            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);


            listRetailCustomers.InsertRange(0, listCorporateCustomers);//omogucava da ubacimo drugu listu elemenata u prvu listu elemenata na određenu poziciju

            foreach (Customer c1 in listRetailCustomers)
            {
                Console.WriteLine($"ID = {c1.ID}, Ime = {c1.Ime}, Placa = {c1.Placa}, Tip = {c1.Tip}");
            }
        }
    }
}
