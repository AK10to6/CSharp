using System;
using System.IO; 

class ExceptionHandle {

    public static void Main() {
        try
        {
            StreamReader strm = null;
            try
            {
                strm = new StreamReader(@"C:\Data.txt"); //Hypothetical file
                Console.WriteLine(strm.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the file {0} exist", ex.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (strm != null)
                {
                    int a = 675765;
                    strm.Close();
                }
                Console.WriteLine("Finally Executed");
            }
        }
        catch (Exception e)
        {

            Console.WriteLine("Current exception:{0}", e.GetType().Name);
            Console.WriteLine("inner exception:{0}", e.InnerException.GetType().Name);
        }
    }
}