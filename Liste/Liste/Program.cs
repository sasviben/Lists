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
            Customer customer4 = new Customer()
            {
                ID = 13,
                Ime = "Vlado",
                Placa = 25000
            };
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
            listCustomers.Add(customer4);

            Customer[] customerArray = new Customer[4];
            customerArray = listCustomers.ToArray();

            foreach(Customer cust in customerArray)
            {
                Console.WriteLine($"ID = {cust.ID}, Ime = {cust.Ime}, Placa = {cust.Placa}");
            }

        }
    }
}
