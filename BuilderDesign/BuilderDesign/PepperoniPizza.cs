using System.Collections.Generic;

namespace BuilderDesign
{
    class PepperoniPizza
    {
        private List<object> _pepperoniPizza = new List<object>();

        public void AddTopping(string pizzaContent)
        {
            this._pepperoniPizza.Add(pizzaContent);
        }

        public string PizzaToppings()
        {
            return "Pizza Topping :" + string.Join(", " , _pepperoniPizza.ToArray());
        }
        
    }

}