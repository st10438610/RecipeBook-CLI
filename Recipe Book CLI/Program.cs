using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Book_CLI
{
    internal class Program
    {
        // Class to store ingredient details
        class Ingredient
        {
            public string Name { get; set; }
            public double Quantity { get; set; }
            public string Unit { get; set; }
        }

        // Class to store recipe steps
        class Step
        {
            public string Description { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Recipe Manager!");

            // 1. Ask the user for the number of ingredients
            Console.Write("\nEnter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            // List to hold all ingredients
            List<Ingredient> ingredients = new List<Ingredient>();

            // 2. Loop to get each ingredient’s details
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"\nEnter details for ingredient {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write("Unit of measurement: ");
                string unit = Console.ReadLine();

                ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });
            }

            // 3. Ask the user for the number of steps
            Console.Write("\nEnter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());

            // List to hold all steps
            List<Step> steps = new List<Step>();

            // 4. Loop to get each step’s description
            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"\nEnter description for step {i + 1}: ");
                string description = Console.ReadLine();
                steps.Add(new Step { Description = description });
            }

            // 5. Output the final recipe
            Console.WriteLine("\n======= Recipe =======");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"- {ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i].Description}");
            }

            Console.WriteLine("\nThank you for using the Recipe Manager!");
        }
    }
}