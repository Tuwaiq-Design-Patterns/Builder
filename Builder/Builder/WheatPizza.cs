using System.Collections.Generic;

namespace Builder
{
    class WheatPizza
    {
        private List<object> wheatPizzaParts = new List<object>();
        public void Add(string part)
        {
            this.wheatPizzaParts.Add(part);
        }
        
        public string PizzaPartsList()
        {
            string str = "";
            for (int i = 0; i < this.wheatPizzaParts.Count; i++)
            {
                str += this.wheatPizzaParts[i] + ",";
            }
            return str;
        }
    }
}