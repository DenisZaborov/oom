using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Task4
{
    public class Business

    {
        //instance variables
        private string name, address;
        private int customers;

        //properties
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int Customers
        {
            get { return customers; }
            set
            {
                if (value >= 0)
                { customers = value; }
            }
        }
        public string CheckLine()
        {
            string x = "Keep on good work!";
            if (customers >= 10)
            {
                x = "Open another counter!";
            }
            if (customers == 0)
            {
                x = "Leave the counter!";
            }
            return x;
        }

        //contstructor
        public Business(string n, string a, int c)
        {
            if (string.IsNullOrWhiteSpace(n)) throw new ArgumentException("Name schould not be empty.", nameof(n));
            if (string.IsNullOrWhiteSpace(a)) throw new ArgumentException("Address should not be empty.", nameof(a));
            if (c < 0) throw new ArgumentException("Customers can not be negative.", nameof(c));
            name = n;
            address = a;
            customers = c;
        }
        public override string ToString()
        {
            string text = null;
            text += "Name: " + Name;
            text += "Adress: " + Address;
            text += "Customers: " + Customers;
            return text;
        }
        static void Main(string[] args)
        {
            const int ARRAY_SIZE = 3;
            int i=0, k=0, l=0;
            string[] names = new string[ARRAY_SIZE] { "Walmart ", "Subway ", "STP " };
            string[] addresses = new string[ARRAY_SIZE] { "204 Street ", "12 Avenue ", "123 Alley " };
            int[] costumers = { 0, 5, 21 };
            Business[] businesses = new Business[ARRAY_SIZE];   //declare the array variable, create the array
            for (int index = 0; index < businesses.Length; index++)
            {
                businesses[index] = new Business(names[i], addresses[k],costumers[l]);
                i++; k++; l++;
                Console.WriteLine("-------Business {0}-------", index+1);
                Console.WriteLine(businesses[index].ToString());
                Console.WriteLine("   {0}", businesses[index].CheckLine());
                Console.WriteLine("--------------------------\n\n");

            }
            Console.ReadLine();
            Console.Clear();
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(businesses, Formatting.Indented));


            Console.ReadLine();
        }

    }   }