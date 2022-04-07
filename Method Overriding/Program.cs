using System;

public class Base {
   
    public virtual void Print()
    {
        Console.WriteLine("Base class Method");
    }
}

public class Derived : Base
{
    public override void Print()
    {
        Console.WriteLine("Derived class Method");
    }

    public static void Main(string[] args)
    {
        Base b = new Derived();
        b.Print();
    }
}