using System;
class Pro
{
    static void Main()
    {
        int totalcost = 0;
        Start: 
        Console.WriteLine("Please Enter choice:");
        Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                totalcost += 1;
                break;
            case 2:
                totalcost += 2;
                break;
            case 3:
                totalcost += 3;
                break;
            default:
                Console.WriteLine("Your choice {0} is Invalid", choice);
                goto Start;
        }
        Decide:
        Console.WriteLine("Do you want to buy another coffee - Y or N");
        string choice2 = Console.ReadLine();

        switch (choice2.ToUpper()) {
            case "Y" :
                goto Start;
            case "N" :
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid. Please try again...", choice2);
                goto Decide;
        }

        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("Your bill amount is: {0}$", totalcost);
    }
}