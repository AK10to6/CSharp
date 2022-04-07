using System;

public class MainClass {
    public static void Main() {
        bool Equal = Calculator.AreEqual<string>("AB", "AB");       //This generic only compare the string values 

        if (Equal)
        {
            Console.WriteLine("Equal");
        }
        else {
            Console.WriteLine("Not Equal");
        }
    }
}
public class Calculator {
    public static bool AreEqual<T>(T Value1, T Value2) { 
        return Value1.Equals(Value2);
    }
}