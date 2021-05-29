namespace DesignPattern
{
    public class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza Pizza { get; set; }

        public WheatPizzaBuilder()
        {
            this.Pizza = new WheatPizza();
        }
        
        public WheatPizza Build()
        {
            WheatPizza pizza = this.Pizza;
            this.Reset();
            return pizza;
        }

        public void Reset()
        {
            this.Pizza = new WheatPizza();
        }

        public IPizzaBuilder BuildDough()
        {
            this.Pizza.Add("Thick");
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