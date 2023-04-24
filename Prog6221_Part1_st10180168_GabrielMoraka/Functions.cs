using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog6221_Part1_st10180168_GabrielMoraka
{
     class Functions
    {

    public    class MethodsAndFunctions
        {
            public string[] ingredients;
            public int[] quantities;
            public string[] units;
            public string[] steps;

            public MethodsAndFunctions()
            {
                // Initialize empty arrays for ingredients, quantities, units, and steps
                ingredients = new string[0];
                quantities = new int[0];
                units = new string[0];
                steps = new string[0];
            }

            public void ingredientDetails()
            {
                // Prompt the user to enter the number of ingredients
                Console.Write("Enter the number of ingredients: ");
                int numberOfIngredients = int.Parse(Console.ReadLine());

                // Initialize the arrays with the correct size
                ingredients = new string[numberOfIngredients];
                quantities = new int[numberOfIngredients];
                units = new string[numberOfIngredients];

                // Prompt the user to enter the details for each ingredient
                for (int i = 0; i < numberOfIngredients; i++)
                {
                    Console.WriteLine($"Enter details for ingredient #{i + 1}:");
                    Console.Write("Name: ");

                    ingredients[i] = Console.ReadLine();
                    Console.Write("Quantity: ");

                    quantities[i] = int.Parse(Console.ReadLine());
                    Console.Write("Unit of measurement: ");
                    units[i] = Console.ReadLine();


                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("The ingredient you entered has been successfully captured\n\n");
                    Console.ResetColor();
                }

                // Prompt the user to enter the number of steps
                Console.Write("Enter the number of steps: ");
                int numberOfSteps = int.Parse(Console.ReadLine());

                // Initialize the steps array with the correct size
                steps = new string[numberOfSteps];

                // Prompt the user to enter the details for each step
                for (int i = 0; i < numberOfSteps; i++)
                {
                    Console.Write($"Enter step #{i + 1}: ");
                    steps[i] = Console.ReadLine();


                  
                }

                Console.Write("The recipe has been successfully captured\n");
            }

            public void fullDisplay()
            {
                // Display the ingredients and quantities
                Console.WriteLine("Ingredients:");
                for (int i = 0; i < ingredients.Length; i++)
                {
                    Console.WriteLine($" {quantities[i]} {units[i]} of {ingredients[i]}");
                }

                // Display the steps
                Console.WriteLine("Steps:");
                for (int i = 0; i < steps.Length; i++)
                {
                    Console.WriteLine($"- {steps[i]}");
                }
            }

            public void ScaleQuantity(int factor)
            {
                // Multiply all the quantities by the scaling factor
                for (int i = 0; i < quantities.Length; i++)
                {
                    quantities[i] *= factor;
                }
            }

            public void ResetQuantities()
            {
                // Reset all the quantities to their original values
                for (int i = 0; i < quantities.Length; i++)
                {
                    Console.Write("You have selected the reset quantity option\n" +
                        "Would you like to rest the quantities\n" +
                        "Press 1 for YES\n" +
                        "press 2 for NO\n");
                    int yesOrNo = Convert.ToInt32(Console.ReadLine());


                    if (yesOrNo ==  1) 
                    {
                        quantities[i] /= 2;
                        Console.Write("The quantites have been changed back to thier original values\n");

                    }
                   
                }

                 



            }

            public void ClearTheRecipe()
            {
                Console.Write("Press 1 to clear the recipe\n" +
                    "Press 2 to cancel\n");
                int clearData = Convert.ToInt32(Console.ReadLine());

                if (clearData == 1)
                {

                    // Reset all the arrays to empty
                    ingredients = new string[0];
                quantities = new int[0];
                units = new string[0];
                steps = new string[0];

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("The recipe has been cleared\n");
                Console.ResetColor(); 
                }


                else if (clearData == 2) 
                {
                    Console.ForegroundColor= ConsoleColor.DarkRed;
                    Console.Write("The Recipe is still saved");
                    Console.ResetColor();
                }
            }
        }









    }
}
