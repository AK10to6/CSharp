using System;
using System.Threading;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter target number:");
        int target = Convert.ToInt32(Console.ReadLine());
        Number num = new Number(target);                            //passing data when creating instance

        Thread t1 = new Thread(num.Print);                          //implicitly applies threadstart delegate
        t1.Start();
    }
}

class Number
{
    private int _target;
    public Number(int target) { this._target = target; }            //Constructor to instialize private field
    public void Print()
    {
        for (int i = 0; i <= _target; i++)
        {
            Console.WriteLine(i);
        }
    }
}