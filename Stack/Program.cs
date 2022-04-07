using System;
using System.Collections.Generic;

namespace Stacks
{
    public class MainClass
    {
        public static void Main()
        {
            Customer c1 = new Customer() { Id = 1, Name = "A", Sal = 5000 };
            Customer c2 = new Customer() { Id = 2, Name = "B", Sal = 4000 };
            Customer c3 = new Customer() { Id = 3, Name = "C", Sal = 3000 };
            Customer c4 = new Customer() { Id = 4, Name = "D", Sal = 2000 };
            Customer c5 = new Customer() { Id = 5, Name = "E", Sal = 6000 };

            Stack<Customer> Scustomer = new Stack<Customer>();                  //Creates a stack of customer type

            Scustomer.Push(c1);                                                 //insert an item at the top of the stack
            Scustomer.Push(c2);
            Scustomer.Push(c3);
            Scustomer.Push(c4);
            Scustomer.Push(c5);

            Customer cc = Scustomer.Peek();                                     //Returns an item from the top of the stack
                                                                                //without removing it
            Console.WriteLine(cc.Id + "--" + cc.Name);
            Console.WriteLine("Total number of elements in stack:{0}", Scustomer.Count());

            Customer cc2 = Scustomer.Pop();                                      //Remove & Returns an item from
                                                                                 //the top of the stack
            Console.WriteLine(cc2.Id + "--" + cc2.Name);
            Console.WriteLine("Total number of elements in stack:{0}", Scustomer.Count());

            Console.WriteLine("All items available in the stack:");             
            foreach (Customer c in Scustomer) {                                 //Looping through each element in the stack
                Console.WriteLine(c.Id + "--" + c.Name);
            }

            if (Scustomer.Contains(c1))                                  //Checks if the object is available in the stack
            {
                Console.WriteLine("C1 exist in the stack");
            }
            else { Console.WriteLine("C1 does not exist in the stack"); }
        }
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Sal { get; set; }
        }
    }
}