using System;
using System.Collections.Generic;

namespace Lists
{
    public class MainClass {
        public static void Main() {

            List<int> numbers = new List<int>() { 5, 7, 2, 7, 9, 3, 2, 8 };
            List<string> str = new List<string>() { "F", "D", "H", "K", "A", "O", "T", "Z" };

            Console.WriteLine("List Before Sorting:");
            foreach (int i in numbers) { 
                Console.WriteLine(i);
            }

            numbers.Sort();                                 //Sorts list in Ascending order
            Console.WriteLine("List After Sorting:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            numbers.Reverse();                              //Sorts list in Decending order
            Console.WriteLine("List in decending order:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            str.Sort();                                 //Sorts string list in Ascending order
            Console.WriteLine("String List After Sorting:");
            foreach (string i in str)
            {
                Console.WriteLine(i);
            }
        }
    } 
}