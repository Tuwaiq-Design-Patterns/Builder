using PizzaMaker.Ingredients;

namespace PizzaMaker.Builders
{
    public interface IPizzaBuilder
    {
        void Reset();
        void SetDough(Dough dough);
        void SetSauce(Sauce sauce);
        void SetCheese(Cheese cheese);
        void SetToppings(Topping[] toppings);
        void SetBakingTime(double hours);
    }
}
