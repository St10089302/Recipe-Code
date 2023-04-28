using System;


namespace ExamplePoe
{
    class Poe
    {
        static void Main(string[] args)
        {
            RecipeManager manager = new RecipeManager(); // Calls the RecipeManager

            while (true)
            {
                Console.WriteLine("Enter a command (create, scale, reset, clear, display, exit):");
                string command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "create":
                        manager.CreateRecipe(); // Call Create module
                        break;
                    case "scale":
                        Console.Write("Enter a scale factor (0.5, 2, 3): ");
                        double factor = double.Parse(Console.ReadLine());
                        manager.ScaleRecipe(factor);
                        break;
                    case "reset":
                        manager.ResetRecipe(); // Call reset module
                        break;
                    case "clear":
                        manager.ClearRecipe(); // Call Clear module
                        break;
                    case "display":
                        manager.DisplayRecipe(); // Call display module
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Invalid command."); // Validation
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
