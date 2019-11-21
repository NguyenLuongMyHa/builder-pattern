using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace character
{
    class Character
    {
        private List<object> charPart = new List<object>();

        public void Add(string part)
        {
            this.charPart.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this.charPart.Count; i++)
            {
                str += this.charPart[i] + ", ";
            }

            str = str.Remove(str.Length - 2); //the last ", "

            return str + "\n";
        }
    }
}
