using System;
using System.Threading;

class Threads {
    public static void Main() {
        Console.WriteLine("Main thread Started");

        Thread T1 = new Thread(Threads.Thread1Function);
        T1.Start();                                         //Executing Thread 1

        Thread T2 = new Thread(Threads.Thread2Function);
        T2.Start();                                         //Executing Thread 2

        T1.Join();                                          //Main thread waits for T1 to Completes its execution
        Console.WriteLine("T1 Function Completed");

        //if (T1.Join(1000))                                  //Checks if thread 1 is completed in 1 second or not
        //{
        //    Console.WriteLine("T1 Function completed in 1 second");
        //}
        //else {
        //    Console.WriteLine("Thread 1 not completed in 1 second");
        //}

        if (T1.IsAlive)                                         //Checks if Thread is still running or not
        {
            Console.WriteLine("Thread 1 is still running");
        }
        else {
            Console.WriteLine("Thread 1 not running anymore");
        }

        T2.Join();                                          //Main thread waits for T2 to Completes its execution
        Console.WriteLine("T2 Function Completed");

        Console.WriteLine("Main Thread Completed");
    }
    public static void Thread1Function() {
        Console.WriteLine("Thread1 Function Started");
        Thread.Sleep(5000);                                 //Putting thread to sleep for 5 Seconds
    }
    public static void Thread2Function()
    {
        Console.WriteLine("Thread2 Function Started");
    }
}