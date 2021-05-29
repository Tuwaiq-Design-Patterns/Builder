using System;

namespace Builder
{
    public class Director
    {
        private IPizzaBuilder builder;

        public IPizzaBuilder Builder
        {
            set
            {
                this.builder = value;
            }
        }

        public void makePizzaMin()
        {
            this.builder.BuildDough();
        }
        public void makePizzaFull()
        {
            this.builder.BuildDough();
            this.builder.BuildSauce();
            this.builder.BuildTopping();
        }

        
        //Bonus 2
        public void SetOrder(string order)
        {
            string[] orderList = order.Split(", ");
            //Console.WriteLine();
            if (orderList[0].ToLower() == "white")
            {
                this.builder = new WhitePizzaBuilder();
            }
            else if (orderList[0].ToLower() == "wheat")
            {
                this.builder = new WheatPizzaBuilder();
            }

            if (orderList[1].ToLower() == "sauce")
            {
                this.builder.BuildSauce();
            }
            
            if (orderList[2].ToLower() == "topping")
            {
                this.builder.BuildTopping();
            }
        }

        // public string GetOrder()
        // {
        //     WheatPizza pizza = builder.ge;
        // }
    }
}