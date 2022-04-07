using System;
using System.Reflection;

namespace Binding
{
    class MainClass
    {
        public static void Main()
        {
            //Customer c = new Customer();                                //  Early Binding:to be used 99.99% of times
            //string fullname = c.FullName("A","K");
            //Console.WriteLine("Full Name: {0}",fullname);

            Assembly executingAssembly = Assembly.GetExecutingAssembly();   // Executing Current Assembly
            Type cType = executingAssembly.GetType("Binding.Customer");     // Getting the Type of Customer class
            object customerInstance = Activator.CreateInstance(cType);      // Creating the instance of the Customer Class

            MethodInfo MethodName = cType.GetMethod("FullName");            // Getting the method Name of the Customer Class 

            string[] parameters = new string[2];                            // Creating Parameters to be passed
            parameters[0] = "A";
            parameters[1] = "K";

            string fullname = (string)MethodName.Invoke(customerInstance, parameters);    // Invoking the method with the instance and parameters, returning to the string
            Console.WriteLine("Full Name: {0}", fullname);
        }
    }
    class Customer
    {
        public string FullName(string FN, String LN)
        {
            return FN + " " + LN;
        }
    }
}