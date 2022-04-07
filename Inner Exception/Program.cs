using System;
using System.IO;

class Pro
{
    public static void Main (){
        try{
            try {
                Console.WriteLine("Enter First Name:");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Name:");
                int SN = Convert.ToInt32(Console.ReadLine());

                int result = FN / SN;

                Console.WriteLine("Result: {0}",result);
            }
            catch (Exception e) {                                    // Inner Exception catched  
                string path = @"C:\Log.txt";
                if (File.Exists(path))
                {

                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine(e.GetType().Name);
                    sw.WriteLine();
                    sw.WriteLine(e.Message);
                    sw.Close();
                    Console.WriteLine("Error Please try later");
                }
                else {
                    throw new FileNotFoundException(path + "not found", e);
                }
            }
        }
        catch(Exception ex) {                                             
            Console.WriteLine("Current Exception = {0}",ex.GetType().Name);
            Console.WriteLine("Inner Exception = {0}",ex.InnerException.GetType().Name);
        }
    }
}