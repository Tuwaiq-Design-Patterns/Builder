using System;
using System.Collections.Generic;

namespace Pizza
{
    public class WheatPizza
    {

        private List<object> info = new List<object>();
        public void Add(string info)
        {
            this.info.Add(info);
        }
        public string Pizza_info()
        {
            string str = "";
            for (int i = 0; i < this.info.Count; i++)
            {
                str += this.info[i] + ",";
            }
            return "WheatPizza: " + str;
        }
    }
}
