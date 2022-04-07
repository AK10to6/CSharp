using System;
using System.Collections.Generic;

namespace SortList
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sal { get; set; }
    }

    public class MainClass
    {
        private static int CompareIdMethod(Customer x, Customer y) {         //Step 1:Create a method which defines comparison
                                                                            //logic based on id
            return x.Id.CompareTo(y.Id);
        }
        public static void Main()
        {
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
                                                                                             //Step 2:
            Comparison<Customer> CustDelegate = new Comparison<Customer>(CompareIdMethod);  //Create instance of Comparison
                                                                                           //delegate & pass name of funtion
                                                                                          //which defines logic to compare
                                                                                         //the objects, So now this delegate
                                                                                        //is pointing to our method

            Lcustomer.Sort(CustDelegate);                                      //Step 3: pass the delegate instance as
                                                                               //argument to sort method
            Console.WriteLine("Sorted list on ID:");
            foreach (Customer c in Lcustomer) {
                Console.WriteLine(c.Id);
            }

            //Alternative option: Instead of above
            //steps we can pass the delegate with definition directy to sort's arguments
            Lcustomer.Sort(delegate(Customer cu1, Customer cu2) { return cu1.Id.CompareTo(cu2.Id); });

            Console.WriteLine("Sorted list on ID by Inline delegate:");
            foreach (Customer c in Lcustomer)
            {
                Console.WriteLine(c.Id);
            }

            //Another Alternative option : Pass the lambda expression as argument to sort method
            Lcustomer.Sort((cu1, cu2) => cu1.Id.CompareTo(cu2.Id));

            Console.WriteLine("Sorted list on ID by lambda Expression:");
            foreach (Customer c in Lcustomer)
            {
                Console.WriteLine(c.Id);
            }


        }
    }
}