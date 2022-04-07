using System;
using System.Collections.Generic;
using System.Linq;

namespace FuncDelegate
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class MainClass
    {
        public static void Main()
        {
            List<Employee> Lemp = new List<Employee>() {
                new Employee{ Id = 101, Name = "Mark" },
                new Employee{ Id = 102, Name = "M" },
                new Employee{ Id = 103, Name = "a" },
                new Employee{ Id = 104, Name = "r" },
                new Employee{ Id = 105, Name = "Kram" }
            };

            Func<Employee, string> selector = emp => "Name = " + emp.Name;      //Creating func delegate to take
                                                                                //input argument of employee type &
                                                                                //return a printed name string  
            IEnumerable<string> names = Lemp.Select(selector);
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }

            Func<int, int, string> funcDelegate = (fn,sn) => "Sum: " + (fn + sn).ToString();    //Using overloaded func delegate
                                                                                                //which takes 2 int input 

            string sum = funcDelegate(10, 20);
            Console.WriteLine(sum);
        }
    }
}