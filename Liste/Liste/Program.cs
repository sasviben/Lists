﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Console.WriteLine("Prije sortiranja");
            foreach (Customer c1 in listCustomers)
            {
                Console.WriteLine($"Placa = {c1.Placa}");
            }

            Console.WriteLine("Nakon sortiranja");

            listCustomers.Sort();//TODO: implement Compare funkciju kako bi mogao sortirati kompleksne tipove podataka

            foreach (Customer c1 in listCustomers)
            {
                Console.WriteLine($"Placa = {c1.Placa}");
            }

            SortByName sbn = new SortByName();
            listCustomers.Sort(sbn);


            Console.WriteLine("Sort by name");
            foreach (Customer c1 in listCustomers)
            {
                Console.WriteLine($"Ime = {c1.Ime}");
            }


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            List<int> numbers = new List<int>() { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before sorting");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Sortirana lista uzlazno");

            numbers.Sort();//sortira brojeve uzlaznim redosljedom

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Sortirana lista silazno");

            numbers.Reverse();//obrne redoslijed elemenata u listi, zadnji je na prvom mjestu, predzadnji na drugom...

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            List<string> alfabet = new List<string>() { "B", "F", "D", "E", "A", "C" };

            Console.WriteLine("Alfabet prije sortiranja");

            foreach (string slovo in alfabet)
            {
                Console.WriteLine(slovo);
            }

            Console.WriteLine("Sortirana lista uzlazno");

            alfabet.Sort();

            foreach (string slovo in alfabet)
            {
                Console.WriteLine(slovo);
            }

            Console.WriteLine("Sortirana lista silazno");

            alfabet.Reverse();

            foreach (string slovo in alfabet)
            {
                Console.WriteLine(slovo);
            }


        }
    }
}
