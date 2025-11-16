using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Klimov.Classes
{
    public class Dish
    {
        public int id;
        public string name;
        public List<Sizes> sizes = new List<Sizes>();
        public string img;
        public List<Ingredients> ingredients = new List<Ingredients>();
        public string description;

        public int activeSize = 0;

        public class Sizes
        {
            public int id;
            public string id_size;
            public int size;
            public int price;
            public int wes;

            public int countOrder;
            public bool orders;
        }

        public class Ingredients
        {
            public int id;
            public string name;
            public int wes;
            public int price;

            public string img;
            public int count;
        }
    }
}
