using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beer3
{
    public class Cat
    {
        public int Mass { get; set; }
        public string Color { get; set; }
        public bool IsAlive { get; set; }
        public string Name { get; set; }
        public CatFood FavoriteFood { get; set; }
        public Cat Father { get; set; }

        public void FeedCat(CatFood food)
        {
            Mass += food.FoodMass;
            Console.WriteLine(Color + " cat ate " + food.FoodMass + " gramms of " + food.FoodName + ". Now it is " + Mass + " gramms.");
        }

        public void Defecate()
        {
            Mass -= 100;
            Console.WriteLine("Jlo, "+Color +" cat posral normalno. Now its weight is "+Mass);
        }

        public void Noooooo()
        {
            if (Father==null)
            {
                Console.WriteLine("Ich, "+Name+ ", the " + Color + " cat - bin sirota");
                return;
            }
            Console.WriteLine(Father.Name+", the "+Father.Color + ": I'm your father, " + Name);
            Console.WriteLine(Name + ", the " + Color+": Nooooooooooooooo");
        }
    }
}
