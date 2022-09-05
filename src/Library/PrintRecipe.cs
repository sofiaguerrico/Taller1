using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class PrintRecipe
    {
        public void PrintRecipes(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}