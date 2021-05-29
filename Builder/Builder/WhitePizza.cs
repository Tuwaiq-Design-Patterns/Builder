using System.Collections.Generic;

namespace Builder
{
    class WhitePizza
    {
        private List<object> whitePizzaParts = new List<object>();
        
        public void Add(string part)
        {
            this.whitePizzaParts.Add(part);
        }
        
        public string PizzaPartsList()
        {
            string str = "";
            for (int i = 0; i < this.whitePizzaParts.Count; i++)
            {
                str += this.whitePizzaParts[i] + ",";
            }
            return str;
        }
    }
}