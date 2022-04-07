using System;
using System.Threading;

public delegate void CallBackDelegate(int sumofnum);                   //Creating delegate to invoke callback method

class MainClass {
    public static void PrintSum(int sum) {                              //The callback method to print sum
        Console.WriteLine("Sum of numbers:{0}", sum);
    }
    public static void Main() {
        Console.WriteLine("Please enter target number:");
        int target = Convert.ToInt32(Console.ReadLine());

        CallBackDelegate cbd = new CallBackDelegate(PrintSum);          //pointing delegate instance to callback method

        Numbers num = new Numbers(target, cbd);                         //passing target value & delegate to constructor
        Thread t1 = new Thread(new ThreadStart(num.SumofNumbers));
        t1.Start();
    }
}

class Numbers {
    private int _target;
    CallBackDelegate _callback;

    public Numbers(int target, CallBackDelegate callback) { 
        this._target = target;
        this._callback = callback;
    }

    public void SumofNumbers() { 
        int sum = 0;
        for (int i = 1; i <= _target; i++)
        {
            sum = sum + i;
        }
        if (_callback != null) { 
            _callback(sum);                                     //Invoking callback method delegate
                                                                //& passing sum of numbers as arguments
        }
    }
}