using System;

class Pro{
    public static void Main() {
        int i = 0;
        int t = 0, p = 0;
        int[] a = {10, 20, 30};

        Cal(i);
        Console.WriteLine("Call by value:");
        Console.WriteLine(i);

        Cal2(ref i);
        Console.WriteLine("Call by reference:");
        Console.WriteLine(i);

        Cal3(10,20,out t, out p);
        Console.WriteLine("Output Parameters:");
        Console.WriteLine("Sum :{0}, Product :{1}",t,p);

        Console.WriteLine("Params Array:");
        Param(a);
    }

    public static void Cal(int j) {
        j = 10;
    }
    public static void Cal2(ref int j)
    {
        j = 10;
    }
    public static void Cal3(int FN, int SN, out int sum, out int prod)
    {
        sum = FN + SN;
        prod = FN * SN;
    }
    public static void Param(params int[] arr)
    { 
        Console.WriteLine("There are {0} Elements.",arr.Length);
        foreach (int i in arr) { 
            Console.WriteLine(i);
        }
    }

}