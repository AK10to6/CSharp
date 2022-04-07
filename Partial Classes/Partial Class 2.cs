using System;


namespace Partial_Classes
{
    public partial class Customer               //Partial class Part
    {
        public string GetFullName() { 
            return _fname + " " + _lname;
        }

        partial void PartialMethod()                //Partial Method Implementation
        {
            Console.WriteLine("Partial Method Invoked");        
        }
    }
}
