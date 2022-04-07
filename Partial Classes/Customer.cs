using System;

namespace Partial_Classes
{
    class CustomerDetails
    {
        public static void Main()
        {
            Customer c = new Customer();            //Using partial class object
            c.Fname = "A";
            c.Lname = "K";

            string fn = c.GetFullName();
            Console.WriteLine(fn);
        }
    }
}
