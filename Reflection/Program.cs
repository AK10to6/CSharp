using System;
using System.Reflection;

namespace Reflect {
    public class MainClass{
        public static void Main() {
            //Type T = Type.GetType("Reflect.Customer");            //Alternamtive For Getting the type
            //Type T = typeof(Customer);                            //Another Alternamtive For Getting the type

            Customer C1 = new Customer();
            Type T = C1.GetType();                                  //Another One

            Console.WriteLine("Full Name: {0}",T.FullName);
            Console.WriteLine("Just Name: {0}",T.Name);
            Console.WriteLine("Namespace : {0}",T.Namespace);
            Console.WriteLine();

            Console.WriteLine("Properties in Customer:");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties) { 
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Methods in Customer:");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Constructors in Customer:");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

        }
    }

    public class Customer {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string Name) {
            this.Name = Name;
            this.Id = ID;
        }

        public Customer() { 
            this.Name = String.Empty;
            this.Id = -1;
        }

        public void PrintID() {
            Console.WriteLine("ID={0}", Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name={0}", Name);
        }
    }
}