using System;
using System.Runtime.InteropServices;                                       //To import Optional attributes

namespace Pro {
    class MainClass {
        public static void Main() {
            Add(10, 20, new int[] { 30, 40, 50 });
        }

        public static void Add(int fn, int sn, [Optional] int[] numbers)        //Assign optional attributes to make parameter optional
        {
            int result = fn + sn;
            if (numbers != null)
            {
                foreach (int i in numbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum:{0}", result);
        }


        //public static void Add(int fn, int sn, int[] numbers = null)        //Assign default value to make parameter optional
        //{
        //    int result = fn + sn;
        //    if (numbers != null)
        //    {
        //        foreach (int i in numbers)
        //        {
        //            result += i;
        //        }
        //    }
        //    Console.WriteLine("Sum:{0}", result);
        //}


        //public static void Add(int fn, int sn)
        //{                                                                   //Method overloading to make parameter optional
        //    Add(fn, sn, null);
        //}
        //public static void Add(int fn, int sn, int[] numbers)           
        //{     
        //    int result = fn + sn;
        //    if (numbers != null)
        //    {
        //        foreach (int i in numbers)
        //        {
        //            result += i;
        //        }
        //    }
        //    Console.WriteLine("Sum:{0}", result);
        //}



        //public static void Add(int fn, int sn, params object[] numbers) {     //Using parameter arrays to make method parameter optional 
        //    int result = fn + sn;
        //    if (numbers != null) {
        //        foreach (int i in numbers) { 
        //            result += i;
        //        }
        //    }
        //    Console.WriteLine("Sum:{0}" ,result);
        //}
    }
}