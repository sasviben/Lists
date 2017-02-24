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
                Placa = 6000
            };

            Customer customer2 = new Customer()
            {
                ID = 11,
                Ime = "Filip",
                Placa = 9000
            };

            Customer customer3 = new Customer()
            {
                ID = 12,
                Ime = "Hrvoje",
                Placa = 15000
            };

            List<Customer> listCust = new List<Customer>();
            listCust.Add(customer1);
            listCust.Add(customer2);
            listCust.Add(customer3);


            if (listCust.Exists(cust => cust.Ime.StartsWith("S")))//provjerava da li element postoji u listi bazirano na zadanom uvjetu
            {
                Console.WriteLine("Ime koje počinje sa slovom S postoji u listi");
            }
            else
            {
                Console.WriteLine("Ime koje počinje sa slovom S ne postoji u listi");
            }
        }
    }
}
