using System;
using System.Collections.Generic;

public class MainClass{ 
    public static void Main() {
        int sum = Calculate.Add(new List<int>() { 10, 20, 30 });
        Console.WriteLine(sum);
    }
}

public class Calculate { 
    [Obsolete("Use Add(List<int> Numbers) Method")]             //Obsolete Attribute Marked and Overloaded by Another Add Method
    public static int Add(int FN, int SN) { 
        return FN + SN;
    }

    public static int Add(List<int> Numbers) { 
        int sum = 0;
        foreach(int num in Numbers){ 
            sum = sum + num;
        }
        return sum;
    }
}