using System;
using static Prog6221_Part1_st10180168_GabrielMoraka.Functions;

namespace RecipeApplication
{
  

    class Program
    {
        static void Main(string[] args)
        {
            MethodsAndFunctions recipe = new MethodsAndFunctions();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("********************************* The Menu *********************************\n" +
                    "Press 1 to enter recipe details");
                Console.WriteLine("Press 2 to display the full recipe");
                Console.WriteLine("Press 3 to scale the quantites");
                Console.WriteLine("Press 4 to reset quantities");
                Console.WriteLine("Press 5 to clear recipe");
                Console.WriteLine("Press 6 to exit\n" +
                    "********************************************************************");
                Console.ResetColor();


                // Using the switch case method to prompt the user to select a number in the menu
                string selection = Console.ReadLine();
                switch (selection)
                { 

                    case "1":
                    recipe.ingredientDetails();
                    break;
                case "2":
                    recipe.fullDisplay();
                    break;
                case "3":
                    Console.Write("Enter scaling factor as a number (half 1, double 2, or triple 3): ");
                    int factor = int.Parse(Console.ReadLine());
                    recipe.ScalingQuantities((int)factor);
                    break;
                case "4":
                    recipe.ResettingTheQuantities();
                    break;
                case "5":
                    recipe.ClearTheRecipe();
                    break;
                        
                case "6":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("The program is exiting...");
                        Console.ResetColor();
                    return;

                default:
                    Console.WriteLine("Invalid option. Please enter a valid option.");
                    break;
                }
            }
        }
    }
}