using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public interface Business
    {
        /// Checks the business descriptors
        string Name
        { get; set; }
        string Address
        { get; set; }
        /// Checks the costumers number in the line
        void CheckLine();
    }



    public class BigCompany : Business

    {
        //instance variables
        private string name;
        private string address;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public void CheckLine()
        {
            int people = 0;
            Console.Write("How many costumers are there?");
            people = Convert.ToInt32(Console.ReadLine());

            if (people >= 10)
            {
                Console.Write("There are too many customers in the line, open another register !");
            }
            if (people == 0)
            {
                Console.Write("There are no customers, you can leave the register !");
            }
        }

        //contstructor
        public BigCompany(string name, string address)
        {
            Name = name;
            Address = address;
        }


        public class SmallBusiness : Business

        {
            //instance variables
            private string name;
            private string address;

            //properties
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Address
            {
                get { return address; }
                set { address = value; }
            }
            public void CheckLine()
            {
                int people = 0;
                Console.Write("How many costumers are there?");
                people = Convert.ToInt32(Console.ReadLine());

                if (people >= 5)
                {
                    Console.Write("There are too many customers in the line, open another register !");
                }
                if (people == 0)
                {
                    Console.Write("There are no customers, you can leave the register !");
                }
            }

            //contstructor
            public SmallBusiness(string name, string address)
            {
                Name = name;
                Address = address;
            }



            public static void Main(string[] args)
            {
                {
                    const int ARRAY_SIZE = 3;
                    Business[] businesses = new Business[ARRAY_SIZE];
                    businesses[0] = new BigCompany("Wallmart", "123 Street");
                    businesses[1] = new SmallBusiness("ABC", "1st Avenue");
                    businesses[2] = new BigCompany("Mega Buy", "Long Alley");

                    for (int index = 0; index < businesses.Length; index++)
                    {
                        Console.WriteLine("  Business Name: {0}, Business Adress: {1}", businesses[index].Name , businesses[index].Address);
                        businesses[index].CheckLine();                        
                    }
                    Console.ReadLine();

                }                 
            }
        }
    }
}
        
