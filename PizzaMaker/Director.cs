using PizzaMaker.Builders;

namespace PizzaMaker
{
    public class Director
    {
        private IPizzaBuilder pizzaBuilder;
        public IPizzaBuilder PizzaBuilder { set { pizzaBuilder = value; } }
        public void BuildPepperoni()
        {
            pizzaBuilder.SetDough(null /* You can set here any Dough that inherits Dough class */);
            pizzaBuilder.SetSauce(null /* usually tomato sauce */);
            pizzaBuilder.SetCheese(null /* mozzarella? */);
            pizzaBuilder.SetToppings(null /* Pepperoni of course */);
        }
        public void BuildMargarita()
        {
            pizzaBuilder.SetDough(null);
            pizzaBuilder.SetSauce(null);
            pizzaBuilder.SetCheese(null /* main ingredient */);
        }
        public void BuildVeggie()
        {
            pizzaBuilder.SetDough(null);
            pizzaBuilder.SetSauce(null);
            pizzaBuilder.SetCheese(null);
            pizzaBuilder.SetToppings(null /* List of Veggies */);
        }
    }
}
