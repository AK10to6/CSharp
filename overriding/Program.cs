using System;

namespace projesct
{
    public class Base
    {
        public string fname, lname;

        public void Print() //Hidden Method
        {
            Console.WriteLine(fname + " " + lname);
        }

    }
    public class Derived : Base
    {
        public new void Print() //Exposed Method
        {
            Console.WriteLine(fname + " " + lname + " Derived ");
        }

        public static void Main(string[] args)
        {
            Derived d = new Derived();
            d.fname = "A";
            d.lname = "K";
            d.Print();
        }
    }
}