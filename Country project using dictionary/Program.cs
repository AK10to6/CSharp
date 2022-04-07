using System;
namespace CountryCode{
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
    public class MainClass {
        public static void Main() { 
            Country c1 = new Country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
            Country c2 = new Country() { Code = "IND", Name = "India", Capital = "New Delhi" };
            Country c3 = new Country() { Code = "USA", Name = "United States", Capital = "Washington D.C." };
            Country c4 = new Country() { Code = "GBR", Name = "United Kingdom", Capital = "London" };
            Country c5 = new Country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };

            Dictionary<string, Country> Dcountry = new Dictionary<string, Country>();

            Dcountry.Add(c1.Code, c1);
            Dcountry.Add(c2.Code, c2);
            Dcountry.Add(c3.Code, c3);
            Dcountry.Add(c4.Code, c4);
            Dcountry.Add(c5.Code, c5);

            string userchoice = string.Empty;

            do
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Please Enter Country Code");
                string strCode = Console.ReadLine().ToUpper();

                Country resCountry = Dcountry.ContainsKey(strCode) ? Dcountry[strCode] : null;  //Checks if dictionary contains the
                                                                                                //input code,
                                                                                                //if yes then return the matching key's value
                                                                                                //or return null
                if (resCountry == null)
                {
                    Console.WriteLine("Country code not valid");
                }
                else
                {
                    Console.WriteLine("Name:{0}, Capital:{1}", resCountry.Name, resCountry.Capital);
                }
                do
                {
                    Console.WriteLine("Do you want to Continue - YES or NO?");
                    userchoice = Console.ReadLine().ToUpper();
                } while (userchoice != "NO" && userchoice != "YES"); 
            } while (userchoice == "YES");
        }
    }
}