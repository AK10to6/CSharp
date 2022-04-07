using System;
using System.Collections.Generic;

namespace Sortlist{
    public class Customer : IComparable<Customer>               //Implements this interface first
                                                                //to let the .net runtime know that you want
                                                                //to sort this type 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sal { get; set; }

        public int CompareTo(Customer other) {                  //implements compareTo function to compare its objects
            return this.Sal.CompareTo(other.Sal);               //Comparing instances based ONLY on the salary
                                                                //Here salary is of type int & int has already implemented 
                                                                //the compareTo function, so we are using that
        }
    }
    public class sortbyname : IComparer<Customer>               //Implement this interface to define your own compare
                                                                //function for customer type 
    {
        public int Compare(Customer x, Customer y) {            //Creating customized sorting for list by names
            return x.Name.CompareTo(y.Name);
        }
    }
    public class MainClass {
        public static void Main() {
            Customer c1 = new Customer()
            {
                Id = 1,
                Name = "F",
                Sal = 5000
            };
            Customer c2 = new Customer()
            {
                Id = 2,
                Name = "K",
                Sal = 4000
            };
            Customer c3 = new Customer()
            {
                Id = 3,
                Name = "B",
                Sal = 3000
            };

            List<Customer> Lcustomer = new List<Customer>();           
            Lcustomer.Add(c1);                                          
            Lcustomer.Add(c2);
            Lcustomer.Add(c3);

            Console.WriteLine("Customer Salary before sorting:");
            foreach (Customer c in Lcustomer) { 
                Console.WriteLine(c.Sal);
            }

            Lcustomer.Sort();
            Console.WriteLine("Customer Salary after sorting:");
            foreach (Customer c in Lcustomer)
            {
                Console.WriteLine(c.Sal);
            }

            sortbyname sbn = new sortbyname();                  //Creating instance of class which defines sorting 
                                                                //BASED ON NAMES.
            Lcustomer.Sort(sbn);                                //Pass that instance as an argument to the sort method
                                                                //to sort list by names

            Console.WriteLine("Sorting list by Names:");            
            foreach (Customer c in Lcustomer) {
                Console.WriteLine(c.Name);
            }
        }
    }

}