namespace builder
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string[] Topping { get; set; }

        public string DescribePizza()
        {
            string description = "";
            description = "Pizza Description -> Dough: " + this.Dough + " Sauce: " + this.Sauce + " Topping: ";
            foreach (var topping in this.Topping)
            {
                description += topping + " ";
            }
            return description;
        }
    }
}