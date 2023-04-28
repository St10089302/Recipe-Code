using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePoe
{
     class RecipeManager //Holds the recipes options of creating, scale, reset, display
    {
        
        private Recipe recipe;
        private double scale = 1.0;
        public void CreateRecipe() //Creates the recipe with ingridents
        {
            recipe = new Recipe();

            Console.Write("Enter the number of ingredients: "); //Message for user to enter data
            recipe.NumIngredients = int.Parse(Console.ReadLine());

            recipe.Ingredients = new string[recipe.NumIngredients];
            for (int i = 0; i < recipe.NumIngredients; i++)
            {
                Console.WriteLine($"Enter ingredient {i + 1}:");
                Console.Write("  Name: ");
                string name = Console.ReadLine();
                Console.Write("  Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("  Unit of measurement: ");
                string unit = Console.ReadLine();
                recipe.Ingredients[i] = $"{quantity} {unit} {name}";
            }

            Console.Write("Enter the number of steps: ");
            recipe.NumSteps = int.Parse(Console.ReadLine());

            recipe.Steps = new string[recipe.NumSteps];
            for (int i = 0; i < recipe.NumSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                Console.Write("  Description: ");
                recipe.Steps[i] = Console.ReadLine();
            }
        }

        public void ScaleRecipe(double factor)
        {
            scale = factor;

            for (int i = 0; i < recipe.NumIngredients; i++)
            {
                string[] parts = recipe.Ingredients[i].Split(' ');
                double quantity = double.Parse(parts[0]);
                quantity *= scale;
                recipe.Ingredients[i] = $"{quantity} {parts[1]} {parts[2]}";
            }
        }

        public void ResetRecipe() //Resets the values back to originals of 0.1 scale
        {
            scale = 1.0;
        }

        public void ClearRecipe() //Clears the whole recipe
        {
            recipe = null;
        }

        public void DisplayRecipe() //Display the Whole recipe after creation
        {
            if (recipe == null)
            {
                Console.WriteLine("No recipe found."); // Vaalidation
                return;
            }

            Console.WriteLine($"Ingredients ({recipe.NumIngredients}):"); 
            for (int i = 0; i < recipe.NumIngredients; i++)
            {
                Console.WriteLine($"  {recipe.Ingredients[i]}");
            }

            Console.WriteLine($"Steps ({recipe.NumSteps}):");
            for (int i = 0; i < recipe.NumSteps; i++)
            {
                Console.WriteLine($"  Step {i + 1}: {recipe.Steps[i]}");
            }

            Console.WriteLine($"Scale factor: {scale}");
        }
    

}
}
