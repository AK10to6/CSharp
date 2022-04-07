using System;

interface I1 {
    void Print();
}
interface I2 { 
    void Print();
}
public class klas: I1,I2 {
    public void Print(){                                                     //Default Implemenntation       
        Console.WriteLine("Method of I1 Interface");      
    }
    void I2.Print() {                                                         //Explicit Implementation
        Console.WriteLine("Method of I2 Interface");
    }

    public static void Main(String[] args) { 
        klas k = new klas();
        k.Print();                      //Default Calling
        ((I2)k).Print();                //Explicit Calling
    }

}