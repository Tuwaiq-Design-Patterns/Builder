namespace Builder
{
    class WhitePizzaBuilder : IPizzaBuilder
    {
        private WhitePizza Pizza = new WhitePizza();
        public void Reset()
        {
            this.Pizza = new WhitePizza();
        }

        public void BuildDough()
        {
            this.Pizza.Add("White Dough");
        }

        public void BuildSauce()
        {
            this.Pizza.Add("Sauce");
        }

        public void BuildTopping()
        {
            this.Pizza.Add("Topping");
        }
        
        public WhitePizza GetPizza()
        {
            WhitePizza pizza = this.Pizza;
            this.Reset();
            return pizza;
        }
    }
}