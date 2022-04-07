using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lists
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sal { get; set; }
    }

    public class MainClass
    {
        public static void Main()
        {
            Customer c1 = new Customer()
            {
                Id = 1,
                Name = "A",
                Sal = 5000
            };
            Customer c2 = new Customer()
            {
                Id = 2,
                Name = "B",
                Sal = 4000
            };
            Customer c3 = new Customer()
            {
                Id = 3,
                Name = "C",
                Sal = 3000
            };

            List<Customer> Lcustomer = new List<Customer>(10);           //Creating list of size 10
            Lcustomer.Add(c1);                                          //Adding items in list
            Lcustomer.Add(c2);
            Lcustomer.Add(c3);                                          //Automatically increases size for another element

            /*Lcustomer.Insert(0, c3);*/                                    //Inserting c3 object in index 0 of list

            foreach (Customer c in Lcustomer) {                         //Printing list elements
                Console.WriteLine("ID:{0}, Name:{1}, Salary:{2} ", c.Id, c.Name, c.Sal);
            }
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Index no of c2: {0}", Lcustomer.IndexOf(c2));                   //returns index no of particular item in the list

            if (Lcustomer.Contains(c3))                                 //Checks if an item exists in list
            {
                Console.WriteLine("C3 Exist in the list");
            }
            else {
                Console.WriteLine("C3 does not exist in the list");
            }
            Console.WriteLine("----------------------------------------------------");
            if (Lcustomer.Exists(cust => cust.Name.StartsWith("A")))    //Checks if an item exists in list on a condition
            {
                Console.WriteLine("Exist");
            }
            else
            {
                Console.WriteLine("Does not exist");
            }
            Console.WriteLine("----------------------------------------------------");
            Customer cu = Lcustomer.Find(cust => cust.Sal>3000);        //searches for element in list that mathches the condition
                                                                        //and returns first matching item
            Console.WriteLine("Name:{0}, ID:{1}, Salary:{2}", cu.Name, cu.Id, cu.Sal);

            Console.WriteLine("----------------------------------------------------");
            Customer cul = Lcustomer.FindLast(cust => cust.Sal > 3000);        //searches for element in list that mathches the condition
                                                                               //and returns last matching item
            Console.WriteLine("Name:{0}, ID:{1}, Salary:{2}", cul.Name, cul.Id, cul.Sal);

            Console.WriteLine("----------------------------------------------------");
            List<Customer> cuall = Lcustomer.FindAll(cust => cust.Sal > 3000);        //searches for elements in list that mathches the condition
                                                                                      //and returns all matching item in list
            foreach (Customer c in cuall)
            {
                Console.WriteLine("Name:{0}, ID:{1}, Salary:{2}", c.Name, c.Id, c.Sal); 
            }
            Console.WriteLine("----------------------------------------------------");
            int index = Lcustomer.FindIndex(cust => cust.Sal>3000);                 //returns index no of first element
                                                                                    //that matches the condition 
            Console.WriteLine("Index:{0}", index);

            Console.WriteLine("----------------------------------------------------");
            int index2 = Lcustomer.FindLastIndex(cust => cust.Sal>3000);               //returns index no of last element
                                                                                       //that matches the condition 
            Console.WriteLine("Index:{0}", index2);

            Customer[] custArray = new Customer[] { c1, c2, c3 };                           //Array of Customer

            List<Customer> arytolist = custArray.ToList();                                  //Converting array to list
            Customer[] listtoary = Lcustomer.ToArray();                                     //Converting list to array
            Dictionary<int, Customer> Ldictionary = Lcustomer.ToDictionary(x => x.Id);      //Converting list to dictionary

            Lcustomer.AddRange(arytolist);               //Add items of arytolist to Lcustomer
            Lcustomer.InsertRange(2, arytolist);         //insert items of arytolist to Lcustomer after specific index
            List<Customer> Lcust2 = Lcustomer.GetRange(0,1); //returns list of items from index 0 to 1 

            Lcustomer.Remove(c1);                       //Removes c1 element from the list
            Lcustomer.RemoveAt(2);                      //Removes item at specified index
            Lcustomer.RemoveAll(x => x.Sal>3000);       //Removes all items which matches the specific expression
            Lcustomer.RemoveRange(0, 1);                //Removes items from specific index, and how many items to remove

            Console.WriteLine("----------------------------------------------------");


            //Returns bool value if this expression applies to all item in the list
            Console.WriteLine("Are all salary greater than 4000:{0}", Lcustomer.TrueForAll(x => x.Sal > 4000)); 
            
            ReadOnlyCollection<Customer> roc = Lcustomer.AsReadOnly();      //Returns a read only wrapper for the list
                                                                            //which cannot be modified by user
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("List Capacity Before Trimming:{0}", Lcustomer.Capacity);
            Lcustomer.TrimExcess();                                         //sets the capacity to actual number of element in the list
            Console.WriteLine("List Capacity After Trimming:{0}", Lcustomer.Capacity);




        }
    }
}