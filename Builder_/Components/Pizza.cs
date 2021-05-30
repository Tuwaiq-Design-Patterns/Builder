namespace builder_
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string[] Topping { get; set; }

        public string DelieveredPizza()
        {
            string msg = "";
            msg = "The Delievered Pizza Details: dough: " + this.Dough + "| sauce: " + this.Sauce + "| topping: ";
            if (this.Topping != null)
            {
                foreach (var t in this.Topping)
                {
                    msg += t + " ";
                }
            }
            return msg;
        }
    }
}