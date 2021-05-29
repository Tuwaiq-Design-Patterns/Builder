namespace DesignPattern
{
    public class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza Pizza { get; set; }

        public WhitePizzaBuilder()
        {
            this.Pizza = new WhitePizza();
        }

        public WhitePizza Build()
        {
            WhitePizza pizza = this.Pizza;
            this.Reset();
            return pizza;
        }

        public void Reset()
        {
            this.Pizza = new WhitePizza();
        }

        public IPizzaBuilder BuildDough()
        {
            this.Pizza.Add("Thin");
            return this;
        }

        public IPizzaBuilder BuildSauce()
        {
            this.Pizza.Add("Tomato sauce");
            return this;
        }

        public IPizzaBuilder BuildTopping()
        {
            this.Pizza.Add("Cheese");
            return this;
        }
    }
}