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
            listCust.Insert(0, customer3);//ubacuje element na 0-tu poziciju
            Console.WriteLine(listCust.IndexOf(customer3));//dohvaca poziciju prvog customer3 objekta u listi pocevsi od nultog indeksa u listi
            Console.WriteLine(listCust.IndexOf(customer3,1));//dohvaca poziciju prvog customer3 objekta u listi pocevsi od prvog indeksa u listi
            Console.WriteLine(listCust.IndexOf(customer3,1,3));//dohvaca poziciju prvog customer3 objekta u listi pocevsi od prvog indeksa u listi, te ide do drugog elementa u listi


        }
    }
}
