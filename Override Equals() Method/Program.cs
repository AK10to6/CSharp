using System;

class MainClass {
    public static void Main() {
        Customer C1 = new Customer();
        C1.FName = "A";
        C1.LName = "K";

        Customer C2 = new Customer();
        C2.FName = "A";
        C2.LName = "K";

        Console.WriteLine(C1 == C2);                //Checks the Reference Equality of Reference Variables
        Console.WriteLine(C1.Equals(C2));           //Checks the Value Equality of Reference Variables
    }
}

class Customer { 
    public string FName { get; set; }
    public string LName { get; set; }

    public override bool Equals(object obj)         //Overriding the equals() method
    {
        if (obj == null) { 
            return false;
        }
        if (!(obj is Customer)) {
            return false;
        }

        return this.FName == ((Customer)obj).FName && this.LName == ((Customer)obj).LName;
    }

    public override int GetHashCode()
    {
        return this.FName.GetHashCode() ^ this.LName.GetHashCode();
    }
}