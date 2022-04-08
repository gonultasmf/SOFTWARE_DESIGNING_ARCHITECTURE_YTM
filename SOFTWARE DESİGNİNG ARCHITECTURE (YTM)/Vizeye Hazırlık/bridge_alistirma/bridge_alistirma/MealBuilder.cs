using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_alistirma
{
    class MealBuilder
    {
        public Meal meal = new Meal();
        public Meal prepareVegMeal()
        {
            meal.addItem(new VegBurger());
            meal.addItem(new Pepsi());
            return meal;
        }
        public Meal prepareNonVegMeal()
        {
            meal.addItem(new ChickenBurger());
            meal.addItem(new Coke());
            return meal;
        }
    }
}
