using System;

namespace Anonymous {
    class MainClass {
        public static void Main() {
            List<Employee> Lemp = new List<Employee>() { 
                new Employee{ Id = 101, Name = "Mark" },
                new Employee{ Id = 102, Name = "M" },
                new Employee{ Id = 103, Name = "a" },
                new Employee{ Id = 104, Name = "r" },
                new Employee{ Id = 105, Name = "Kram" }
            };

            //static bool FindEmployee(Employee emp){
            //    return emp.Id == 102;
            //}
            //Predicate<Employee> empPredicate = new Predicate<Employee>(FindEmployee);
            //Employee emp = Lemp.Find(x => empPredicate(x));

            //Intead of all above code we can directly pass delegate as an argument to find method by creating
            //ANONYMOUS Method
         

            Employee emp = Lemp.Find(delegate (Employee x){ return x.Id == 102;});       //Creating ANONYMOUS method
                                                                                         //and defining logic inline
                                                                                         //its easy to write as you
                                                                                         //don't have to create instance
                                                                                         //of delegate separately
                                                                                         //and point it to a method
            Console.WriteLine("ID: {0},Name: {1}", emp.Id, emp.Name);
        }                                                                           //With ANONYMOUS methods delegate's
                                                                                    //parameters are optional
    }

    public class Employee{ 
        public int Id { get; set; }
        public string Name { get; set; }
    }  
}