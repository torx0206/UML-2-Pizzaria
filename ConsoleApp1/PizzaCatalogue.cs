using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PizzaCatalogue
    {

        private Dictionary<int, Pizza> _pizzas;

        public PizzaCatalogue()
        {
            _pizzas = new Dictionary<int, Pizza>();
        }



        public int Count
        {
            get { return _pizzas.Count; }
        }


        public void AddPizza(Pizza aPizza)
        {
            if (!_pizzas.ContainsKey(aPizza.Nr))
                _pizzas.Add(aPizza.Nr, aPizza);


        }


        public Pizza LookupPizza(int nr)
        {
            if (_pizzas.ContainsKey(nr) == true)
            {
                return _pizzas[nr];
            }


            return null;
        }


        public void DeletePizza(int nr)
        {
            if (_pizzas.ContainsKey(nr) == true)
            {
                _pizzas.Remove(nr);
            }

        }


        public void PrintPizzas()
        {
            foreach (Pizza pizza in _pizzas.Values)
            {
                Console.WriteLine(pizza);
            }
        }

        public void UpdatePizza(int nr, Pizza pizzaToUpdate)
        {
            if (_pizzas.ContainsKey(nr) == true)
                _pizzas[nr] = pizzaToUpdate;
        }
    }
}
