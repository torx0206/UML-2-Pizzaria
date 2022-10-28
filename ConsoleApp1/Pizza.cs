using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class Pizza
    {
        private string _name;
        private int _nr;
        private int _price;
        private List<Ingredient> _ingredients;
        private string _ingredientlist;
        
        public string Name
        {
            get { return _name; }
        }
        public int Nr
        {
            get { return _nr; }
        }
        public int Price
        {
            get { return _price; }
        }
        
        public Ingredient FindIngredient(string name)
        {
            foreach (Ingredient ingredient in _ingredients)
            {
                if (ingredient.Name == name)
                {
                    return ingredient;
                }
            }
            return null;
        }


        public void RemoveIngredient(string ingrName)
        {
            Ingredient item = FindIngredient(ingrName);
            _ingredients.Remove(item);
        }

        public void AddIngredient(string ingrName)
        {
            _ingredients.Add(new Ingredient(ingrName));
        }
        
        public string ListOfIngredients()
        {
            _ingredientlist = "";
            int i = 1;
            foreach (Ingredient ingredient in _ingredients)
            {
                
                _ingredientlist = _ingredientlist + ingredient.ToString();
                if (i < _ingredients.Count)
                {
                    _ingredientlist = _ingredientlist + ", ";
                }
                i++;
            }
            
            return _ingredientlist;
        }
        public override string ToString()
        {
            return $"nr {_nr} name {_name} ingredients {ListOfIngredients()}";
        }
        public Pizza(int nr, string name, int price, string ingr1, string ingr2)
        {
            _nr = nr;
            _name = name;
            _price = price;
            _ingredients = new List<Ingredient>();
            
            _ingredients.Add(new Ingredient(ingr1));
            _ingredients.Add(new Ingredient(ingr2));
        }
    }
}
