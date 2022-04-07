using System;
using System.Collections.Generic;

namespace Queues {
    public class MainClass {
        public static void Main() {
            Customer c1 = new Customer(){ Id = 1,Name = "A", Sal = 5000 };
            Customer c2 = new Customer(){ Id = 2,Name = "B", Sal = 4000 };
            Customer c3 = new Customer(){ Id = 3,Name = "C", Sal = 3000 };
            Customer c4 = new Customer(){ Id = 4,Name = "D", Sal = 2000 };
            Customer c5 = new Customer(){ Id = 5,Name = "E", Sal = 6000 };

            Queue<Customer> Qcustomer = new Queue<Customer>();          //Create a Queue of type customer
            Qcustomer.Enqueue(c1);                                      //Add an element to the end of the queue
            Qcustomer.Enqueue(c2);
            Qcustomer.Enqueue(c3);
            Qcustomer.Enqueue(c4);
            Qcustomer.Enqueue(c5);

            Customer cc = Qcustomer.Peek();                        //Just Returns the element from the beginning of queue
            Console.WriteLine(cc.Id + " - " + cc.Name);
            Console.WriteLine("Total items in the queue:{0}", Qcustomer.Count);


            Customer cc2 = Qcustomer.Dequeue();                          //REMOVES and return the element from
                                                                        //the beginning of queue 
            Console.WriteLine(cc2.Id + " - " + cc2.Name);
            Console.WriteLine("Total items in the queue:{0}",Qcustomer.Count);

            Console.WriteLine("Available elements in the queue:");
            foreach (Customer c in Qcustomer){                          //Loop through each element in the queue
                Console.WriteLine(c.Id + " - " + c.Name);
            }

            if (Qcustomer.Contains(c1))                                //Checks if the object is available in the queue
            {
                Console.WriteLine("C1 Exist in the Queue");
            }
            else {
                Console.WriteLine("C1 does not exist in the Queue");
            }
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sal { get; set; }
    }
}