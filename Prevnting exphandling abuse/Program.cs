using System;
public class ExceptionHandleAbuse {
    public static void Main(string[] args) {

        try
        {
            Console.WriteLine("Please Enter Numerator:");
            int numerator, denominator;
            bool isnumerator = Int32.TryParse(Console.ReadLine(), out numerator) ;
            if (isnumerator)
            {
                Console.WriteLine("Please Enter Denominator:");
                bool isdenominator = Int32.TryParse(Console.ReadLine(), out denominator);
                if (isdenominator && denominator != 0)
                {
                    int result = numerator / denominator;
                    Console.WriteLine("Result:{0}", result);
                }
                else
                {
                    if (denominator == 0)
                    {
                        Console.WriteLine("Cannot Enter 0");
                    }
                    else
                    {
                        Console.WriteLine("Denominator should be valid no between {0} & {1}", Int32.MinValue, Int32.MaxValue);
                    }
                }
            }
            else {
                Console.WriteLine("Numerator should be valid no between {0} & {1}", Int32.MinValue, Int32.MaxValue);
            }
        }
        catch (Exception ex) { 
            Console.WriteLine(ex.Message);
        }
    } 
}