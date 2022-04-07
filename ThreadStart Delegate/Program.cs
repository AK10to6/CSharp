using System;
using System.Threading;

class Program
{
    public static void Main()
    {
        Thread t1 = new Thread(new ThreadStart(Number.Print));                  //passing threadstart delegate as argument to thread
                                                                                //class constructor which points to print method

        //Thread t1 = new Thread(delegate() { Number.Print(); } ) ;             //alternative  to execute the print method
        //Thread t1 = new Thread(() => Number.Print() );                        //using lambda expression to execute print method

        t1.Start();
    }
}

class Number
{
    public static void Print()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}