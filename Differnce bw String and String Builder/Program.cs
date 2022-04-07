using System;
using System.Text;

class MainClass {
    public static void Main() {
        string str = "A";                           //This String manipulation Process takes more space in memory
        str += "Y";
        str += "U";
        str += "S";
        str += "H";
        Console.WriteLine(str);                     

        StringBuilder str2 = new StringBuilder("A"); //This Process takes less memory and gives better performance
        str2.Append("Y");
        str2.Append("U");
        str2.Append("S");
        str2.Append("H");
        Console.WriteLine(str2.ToString());
    }
}