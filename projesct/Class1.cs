using System;

namespace projesct
{
    public class Base
    {
        public string fname, lname;

        public void Print()
        {
            Console.WriteLine(fname + " " + lname);
        }

    }
    public class Derived : Base
    {
        public new void Print()
        {
            Console.WriteLine(fname + " " + lname);
        }
    }

    public static void main(string[] args)
    {
        Derived d = new Derived();
        d.Print();
    }
}