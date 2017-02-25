using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Liste
{
     class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public int Placa { get; set; }
        public string Tip { get; set; }

        int IComparable<Customer>.CompareTo(Customer other)
        {
            /*if (this.Placa > other.Placa)
                return 1;
            else if (this.Placa < other.Placa)
                return -1;
            else
                return 0;*/

            return this.Placa.CompareTo(other.Placa);//kraci zapis
        }

      

    }
     class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Ime.CompareTo(y.Ime);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer1 = new Customer()
            {
                ID = 10,
                Ime = "Sandro",
                Placa = 9000,
                Tip = "RetailCustomer"
            };

            Customer customer2 = new Customer()
            {
                ID = 11,
                Ime = "Filip",
                Placa = 6000,
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
             List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer3);
            listCustomers.Add(customer2);
            listCustomers.Add(customer4);
            listCustomers.Add(customer5);

            ReadOnlyCollection<Customer> readOnlyCustomers = listCustomers.AsReadOnly();//radi omotac oko liste tako da se moze samo citati, ne moze se modificirati
            Console.WriteLine("Items = " + readOnlyCustomers.Count());

        }
       
    }
}
