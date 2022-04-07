using System;
using System.Threading;
using System.Diagnostics;

class Program {
    static int total = 0;
    public static void Main() {
        
        Stopwatch stopwatch = Stopwatch.StartNew();                     //Start new stopwatch to record time taken to
                                                                        //execute program 

        Thread t1 = new Thread(Program.AddOneMillion);
        Thread t2 = new Thread(Program.AddOneMillion);
        Thread t3 = new Thread(Program.AddOneMillion);

        t1.Start(); t2.Start(); t3.Start();                              
        t1.Join(); t2.Join(); t3.Join();                                //waiting for all threads to complete

        Console.WriteLine("Total: {0}", total);
        
        stopwatch.Stop();                                               //Stopping stopwatch
        Console.WriteLine(stopwatch.ElapsedTicks);                      //Printing elapsed time recorded by stopwatch
    }
    
    static object _lock = new object();                                 //Creating an object                    
    public static void AddOneMillion() {
        for (int i = 1; i <= 1000000; i++)
        {
            //Interlocked.Increment(ref total);                           //Increaments a specified variable & stores
                                                                        //the result, as an atomic operation
            
            lock (_lock)                                                //Locking: a block of code restrictes it to be used
            {                                                           //by one thread at a time, Here total++ is used by 
                total++;                                                //one thread at a time
            }

            //Monitor.Enter(_lock);                                       //This mechanism works same as the locking method
            //try { total++; }
            //finally { Monitor.Exit(_lock); }
        }
    }
}