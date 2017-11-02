using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beer3
{
    public class CatsGame
    {
        public void PlayWithCats()
        {
            var superCat = new Cat();

            superCat.Mass = 1500;
            superCat.IsAlive = true;
            superCat.Color = "Ginger";
            superCat.Name = "Luke";

            var food = new CatFood();
            food.FoodName = "Meat";
            food.FoodMass = 20;

            superCat.FavoriteFood = food;

            var alleyCat = new Cat();
            alleyCat.Mass = 700;
            alleyCat.IsAlive = false;
            alleyCat.Color = "Multi Color";
            alleyCat.Name = "Darth Vader";

            superCat.Father = alleyCat;
            
            var fish = new CatFood();
            fish.FoodMass = 50;
            fish.FoodName = "Fish";

            superCat.FeedCat(fish);

            alleyCat.FeedCat(fish);

            var sukhari = new CatFood();
            sukhari.FoodMass = 20;
            sukhari.FoodName = "Dry Cat Food";
            superCat.FeedCat(sukhari);

            superCat.Defecate();
            string superCatColor = superCat.Color;
            Console.WriteLine(superCatColor);
            Console.WriteLine();
            superCat.Noooooo();
            alleyCat.Noooooo();
        }
    }
}
