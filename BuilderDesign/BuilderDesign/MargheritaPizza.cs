using System.Collections.Generic;

namespace BuilderDesign
{
    class MargheritaPizza
    {
        private List<object> _margheritaPizza = new List<object>();

        public void AddTopping(string pizzaContent)
        {
            this._margheritaPizza.Add(pizzaContent);
        }

        public string PizzaToppings()
        {
            return "Pizza Topping :" + string.Join(", " , _margheritaPizza.ToArray());
        }

    }

}