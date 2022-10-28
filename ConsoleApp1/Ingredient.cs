using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Ingredient
    {
        private string _name;

        public string Name
        {
            get { return _name; }
        }

        public Ingredient(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
