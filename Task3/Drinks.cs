using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Drinks
    {
        Drink[] drinks;
        private void drinksCreate()
        {
            drinks = new Drink[] { new Drink("Coffee", 34.9),
                                   new Drink("Tea", 22.5),
                                   new Drink("Juice", 18.5),
                                   new Drink("Water", 12.00) };
        }

        public Drink SearchDrink(string drinkName)
        {
            Drink drink = drinks.Where(i => i.Title.ToLower().Equals(drinkName.ToLower())).FirstOrDefault();
            return drink;
        }
    }
}
