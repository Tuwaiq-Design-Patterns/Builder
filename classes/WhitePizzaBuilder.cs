namespace builder
{
    public class WhitePizzaBuilder : IPizzaBuilder
    {
        public Pizza Pizza { get; set; }

        public WhitePizzaBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            Pizza = new Pizza();
        }
        public IPizzaBuilder BuildDough(string dough = "White")
        {
            Pizza.Dough = dough;
            return this;
        }
        public IPizzaBuilder BuildSauce(string sauce = "Tomato")
        {
            Pizza.Sauce = sauce;
            return this;
        }
        public IPizzaBuilder BuildTopping()
        {
            Pizza.Topping = new string[] { "Olives", "Red Peppers", "Onions", "Paprika" };
            return this;
        }

        public IPizzaBuilder BuildTopping(string[] topping)
        {
            Pizza.Topping = topping;
            return this;
        }

        public Pizza GetPizza()
        {
            return Pizza;
        }
    }
}