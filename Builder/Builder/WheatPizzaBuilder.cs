namespace Builder
{
    class WheatPizzaBuilder : IPizzaBuilder
    {
        private WheatPizza Pizza = new WheatPizza();
        
        public void Reset()
        {
            this.Pizza = new WheatPizza();
        }

        public void BuildDough()
        {
            this.Pizza.Add("Wheat Dough");
        }

        public void BuildSauce()
        {
            this.Pizza.Add("Sauce");
        }

        public void BuildTopping()
        {
            this.Pizza.Add("Topping");
        }
        
        public WheatPizza GetPizza()
        {
            WheatPizza pizza = this.Pizza;
            this.Reset();
            return pizza;
        }
    }
}