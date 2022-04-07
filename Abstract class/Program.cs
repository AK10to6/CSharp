using System;

public abstract class Abs {
    public abstract void Print();
}

public class Cls: Abs {
    public override void Print() {
        Console.WriteLine("Abstract Method");
    }

    public static void Main(string[] args)
    {
        Cls c = new Cls();
        c.Print();

        //Abs a = new Cls();                Alternative Calling of Method
        //a.Print();
    }
}