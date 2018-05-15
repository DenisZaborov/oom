using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class Business
        
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

        //contstructor
        public Business(string name, string adress)
        {
            Name = name;
            Address = adress;
        }

        //method
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
                Console.Write("There are no customer, you can leave the register !");
            }
        }

               public static void Main(string[] args)
        {
            Business obj = new Business("Shopping Mall", "123 Street");
            Console.WriteLine("{0}", obj.Name);
            Console.WriteLine("{0}", obj.Address);
            obj.CheckLine();
        }
    }
}
