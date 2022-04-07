using System;

public struct Customer {
    //private int id;
    //private string name;

    public string Name { get; set; }
    public int ID { get; set; }
    public Customer(int Id, string Name) { 
        this.ID = Id;
        this.Name = Name;
    }
    public void Print() {
        Console.WriteLine("Id = {0} & Name = {1}",this.ID, this.Name);
    }
}

public class Stu {
    public static void Main(string[] args) { 
        Customer C1 = new Customer(101,"Mark");
        C1.Print();

        Customer C2 = new Customer();
        C2.ID = 102;
        C2.Name = "John";
        C2.Print();

        Customer C3 = new Customer {
                ID = 103,
                Name = "Rob"
        };
        C3.Print();
    }
}