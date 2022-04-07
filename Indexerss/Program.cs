using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Indexers
{
    public class MainClass { 
        public static void Main(){
            Company c = new Company();
            Console.WriteLine("Name of employee id 2:{0}", c[2]);       //Using indexer to print name of Employee 
            c[2] += "aik";                                              //Using indexer to change name of Emolyee
            Console.WriteLine("Name of employee id 2:{0}", c[2]);

            Console.WriteLine(" ");
            Console.WriteLine("Before Changing Values:");
            Console.WriteLine("Numbers of Male Employee:{0}", c["Male"]);       //Using overridden index
            Console.WriteLine("Numbers of FEMale Employee:{0}", c["FEMale"]);

            Console.WriteLine(" ");
            c["Male"] = "FEMale";
            Console.WriteLine("After Changing Values:");
            Console.WriteLine("Numbers of Male Employee:{0}", c["Male"]);
            Console.WriteLine("Numbers of FEMale Employee:{0}", c["FEMale"]);
        }
    }
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }

    public class Company
    {
        private List<Employee> listemployees;

        public Company()
        {
            listemployees = new List<Employee>();
            listemployees.Add(new Employee() { EmpId = 1, Name = "Mike", Gender = "Male" });
            listemployees.Add(new Employee() { EmpId = 2, Name = "M", Gender = "FEMale" });
            listemployees.Add(new Employee() { EmpId = 3, Name = "ike", Gender = "Male" });
            listemployees.Add(new Employee() { EmpId = 4, Name = "Mik", Gender = "FEMale" });
            listemployees.Add(new Employee() { EmpId = 5, Name = "ke", Gender = "Male" });
        }

        public string this[int empid]               //Created an indexer of Company class
        {
            get {return listemployees.FirstOrDefault(emp => emp.EmpId == empid).Name;}
            set {listemployees.FirstOrDefault(emp => emp.EmpId == empid).Name = value;}
        }
        public string this[string gender]               //Overriding an indexer of Company class
        {
            get { return listemployees.Count(emp => emp.Gender == gender).ToString(); }
            set {
                foreach (Employee emp in listemployees) {
                    if (emp.Gender == gender) { 
                        emp.Gender = value;
                    }
                }
            }
        }
    }
}
