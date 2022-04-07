using System;
using System.Collections.Generic;

namespace Dictionary {
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sal { get; set; }
    }
    public class MainClass{ 
        public static void Main() { 
            Customer c1 = new Customer() { 
                Id = 10,
                Name = "A",
                Sal = 5000
            };
            Customer c2 = new Customer() {
                Id = 20,
                Name = "B",
                Sal = 4000
            };
            Customer c3 = new Customer()
            {
                Id = 30,
                Name = "C",
                Sal = 3000
            };

            Dictionary<int, Customer> dcustomer = new Dictionary<int, Customer>();      //Created an dictionary
            dcustomer.Add(c1.Id, c1);                                                   //Add key & values in dictionary 
            dcustomer.Add(c2.Id, c2);
            dcustomer.Add(c3.Id, c3);

            if(!dcustomer.ContainsKey(c3.Id)){                                          //Checks if dictionary coantains specific key
                dcustomer.Add(c3.Id, c3);                                               // if not then add this item to dictionary 
            }


            Customer cust = dcustomer[10];                                              //this returns value for particular key
            Console.WriteLine("Details of Customer ID:10");
            Console.WriteLine("ID: {0}, Name: {1}, Salary: {2} ",cust.Id, cust.Name, cust.Sal);
            Console.WriteLine("------------------------------------------------------------");
            
            Console.WriteLine("All Customer details:");
            foreach (KeyValuePair<int, Customer> i in dcustomer)                     //printing each item in dictionary
            {
                Console.WriteLine("Key:{0}", i.Key);
                Customer c = i.Value;
                Console.WriteLine("ID:{0}, Name: {1}, Salary: {2} ", c.Id, c.Name, c.Sal);
                Console.WriteLine("------------------------------------------------------------");
            }
            Console.WriteLine("------------------------------------------------------------");
            Customer cust2;
            if (dcustomer.TryGetValue(10, out cust2)) {                          //Checks if key exist in dictionary,
                                                                                 //if yes then puts value in variable 
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2} ", cust2.Id, cust2.Name, cust2.Sal);
            }
            else {
                Console.WriteLine("The key is not found...");
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Total Items in Dictionary:{0}", dcustomer.Count);    //Using count property 
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Total Employees with salary more than 3000: {0}", dcustomer.Count(kvp => kvp.Value.Sal>3000));

            Customer[] custArray = new Customer[] { c1, c2, c3 };                       //An array of customers
            Dictionary<int, Customer> arytodict = custArray.ToDictionary(cust => cust.Id, cust => cust);  //Converting array to Dictionary


            //dcustomer.Remove(10);                        //using remove function to remove particular item from dictionary
            //dcustomer.Clear();                           //using clear funtion to remove all items from dictionary 


        }
    }
}