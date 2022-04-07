using System;
namespace Ex{
    class MainClass {
        public static void Main()
        {
            int num = 10;
            Console.WriteLine(num.ToString());           //Printing num as a String to the console with toString() method

            Customer c = new Customer();
            c.FName = "Simon";
            c.LName = "Tan";

            Console.WriteLine(c.ToString());
        }
    }
    public class Customer { 
        public string FName { get; set; }
        public string LName { get; set; }

        public override string ToString()               //Overriding Tostring() method to return custom output
        {
            return this.LName + ", " + this.FName;
        }
    }
}