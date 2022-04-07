using System;
using System.Threading;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter target number:");
        object target = Console.ReadLine();
        Number num = new Number();


        ParameterizedThreadStart pts = new ParameterizedThreadStart(num.Print);       //we use parameterized thread start when we have
                                                                                     //to pass data to the thread function
        Thread t1 = new Thread(pts);

        Thread t2 = new Thread(num.Print);                                           //this also works as compiler implicitily
                                                                                     //applies parameterized thread start here 
        t1.Start(target);
        t2.Start(target);
    }
}

class Number
{
    public void Print(object target)
    {
        int number = 0;

        if (int.TryParse(target.ToString(), out number))
        {
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}