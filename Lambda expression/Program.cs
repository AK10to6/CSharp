using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
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

            Employee emp = Lemp.Find(x => x.Id == 102 );                      //Passing lambda expression
                                                                              //as an argument to Find method
            Console.WriteLine("ID: {0},Name: {1}", emp.Id, emp.Name);

            int count = Lemp.Count(x => x.Name.StartsWith("M"));              //Passing lambda expression
                                                                              //as an argument to Count method
            Console.WriteLine("Count:{0}",count);

            //With LAMBDA EXPRESSION a method or delegate's parameters are NOT optional, unlike Anonymous method.
        }
    }
}