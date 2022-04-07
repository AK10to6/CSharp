using System;
class pro {
    static void Main()
    {
        int totalcost = 0;
        string choice = string.Empty;
        do
        {
            int cofchoice2 = -1;
            do {   
                Console.WriteLine("Please select your coffee choice:");
                Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");
                cofchoice2 = int.Parse(Console.ReadLine());

                switch (cofchoice2) {
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
                        Console.WriteLine("Your choice {0} is invalid", cofchoice2);
                        break;
                }
            }while (cofchoice2 != 1 && cofchoice2 != 2 && cofchoice2 != 3);

            do {
                Console.WriteLine("Do you want to buy another coffee - Y or N?");
                choice = Console.ReadLine().ToUpper();

                if (choice != "Y" && choice != "N") {
                    Console.WriteLine("Your choice {0} is invalid. Please try again...", choice);
                }
            } while (choice != "Y" && choice != "N");
        }while (choice.ToUpper() != "N");

        Console.WriteLine("Thank you for shopping with us");
        Console.WriteLine("Your bill amount is: {0}", totalcost);
    }
}