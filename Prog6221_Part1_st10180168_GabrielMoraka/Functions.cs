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
                // This prompts the user to enter the number of ingredients
                Console.Write("Enter the number of ingredients: ");
                int numberOfIngredients = int.Parse(Console.ReadLine());

                // Initialize the arrays with the correct size
                ingredients = new string[numberOfIngredients];
                quantities = new int[numberOfIngredients];
                units = new string[numberOfIngredients];

                // This is where the user enters the details for the recipe or the ingredient
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

                // This is where the user enters the number of steps
                Console.Write("Enter the number of steps: ");
                int numberOfSteps = int.Parse(Console.ReadLine());

                // Initialize the right size for the steps array
                steps = new string[numberOfSteps];

                // Prompt the user to enter the description in the steps
                for (int i = 0; i < numberOfSteps; i++)
                {
                    Console.Write($"Enter step #{i + 1}: ");
                    steps[i] = Console.ReadLine();


                  
                }
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.Write("The recipe has been successfully captured\n\n");
                Console.ResetColor();   
            }

            public void fullDisplay()
            {
                // Displaying the ingredients and quantities 
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine("\n\n************** The Full Recipe **************\n");
                Console.ResetColor();
                Console.WriteLine("The Ingredients are as follows:\n" +
                    "You will need:\n");


                for (int i = 0; i < ingredients.Length; i++)
                {
                    Console.WriteLine($"- {quantities[i]} {units[i]} of {ingredients[i]}");
                }

                // Display the description in the steps
                Console.WriteLine("\nThe Steps for this recipe are as follows:");
                for (int i = 0; i < steps.Length; i++)
                {
                    Console.WriteLine($" For Step {i + 1}: {steps[i]}");
                    
                }
                Console.WriteLine("\n");
            }

            public void ScalingQuantities(int factor)
            {
                // This is the scaling factor multipying the quantities
                for (int i = 0; i < quantities.Length; i++)
                {

                    if (factor == 1)
                    {
                        quantities[i] /= 2;
                        Console.Write("The quantites are half\n");
                    }

                    else if (factor == 2) 
                    {

                        quantities[i] *= 2;
                        Console.Write("The quantites have been doubled\n");

                    }
                    
                    else if (factor == 3)
                    {
                        quantities[i] *= 3;
                        Console.Write("The quantites have tripled\n");
                    }


                }
            }

            public void ResettingTheQuantities()
            {
                // This is where the clearing of the quantities is 
                for (int i = 0; i < quantities.Length; i++)
                {
                    
                    Console.Write("\nYou have selected the RESET QUANTITES OPTIONS\n" +
                        "Would you like to reset the quantities to their orignal vaules:\n" +
                        "Press 1 for YES\n" +
                        "press 2 for NO\n");
                    int yesOrNo = Convert.ToInt32(Console.ReadLine());


                    if (yesOrNo == 1) 
                    {
                        Console.Write("\nThe quantites have been changed back to thier original values\n");
                        quantities[i] /= 2;

                    }

                    else if (yesOrNo == 2) 
                    {
                        Console.WriteLine("The quantities will not be changed");
                    }

                    else
                    {
                        Console.Write("Invaild number entered, back to menu/n");
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

                    // This is the reset function to remove values in the array and make it empty
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
                    Console.Write("The Recipe is still saved back to the menu");
                    Console.ResetColor();
                }
            }
        }









    }
}
