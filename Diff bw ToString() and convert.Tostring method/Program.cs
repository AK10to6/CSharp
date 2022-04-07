using System;

namespace Program {
    class MainClass {
        public static void Main() { 
            Customer c = null;
            string s = Convert.ToString(c);             //This returns an empty value
            //string s = c.ToString();                  //This throws an null reference exception
            Console.WriteLine(s);
        }
    }

    class Customer { 
        public string Name { get; set; }
    }
}