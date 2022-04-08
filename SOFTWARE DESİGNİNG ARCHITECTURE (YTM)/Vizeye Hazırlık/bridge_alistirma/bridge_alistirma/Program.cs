using System;

namespace bridge_alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();
            mealBuilder.prepareNonVegMeal();
            mealBuilder.meal.showItems();
            Console.WriteLine("Total price is : " + mealBuilder.meal.getCost());

        }
    }
}
