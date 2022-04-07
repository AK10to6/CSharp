using System;

public enum Gender { 
    Unkown,
    Male,
    Female
}
class Enumex {
    public static void Main(string[] args)
    {
        #region CustomerArray                           //Regions in C#
        Customer[] c = new Customer[3];

        c[0] = new Customer { 
            Name = "MARK",
            Gender = Gender.Male
        };
        c[1] = new Customer
        {
            Name = "Rakhi",
            Gender = Gender.Female
        };
        c[2] = new Customer
        {
            Name = "Frank",
            Gender = Gender.Unkown
        };
        #endregion
        foreach (Customer cust in c) { 
            Console.WriteLine("Name = {0} && Gender = {1}", cust.Name, GetGender(cust.Gender));
        }
    }

    public static string GetGender(Gender g) {
        switch (g) { 
            case Gender.Male:
                return "Male";
            case Gender.Female:
                return "Female";
            case Gender.Unkown:
                return "Unknown";
            default:
                return "Not Valid";
        }
    }

}

public class Customer { 
    public string Name { set; get; } 
    public Gender Gender { set; get; }
}