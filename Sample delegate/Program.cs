using System;

public delegate void sDelegate();

class Pro {

    public static void Main(string[] args) {

        sDelegate del = new sDelegate(M1);
        del += M2;
        del += M3;

        del();
    }

    public static void M1() {
        Console.WriteLine("M1 Method");
    }
    public static void M2()
    {
        Console.WriteLine("M2 Method");
    }
    public static void M3()
    {
        Console.WriteLine("M3 Method");
    }

}