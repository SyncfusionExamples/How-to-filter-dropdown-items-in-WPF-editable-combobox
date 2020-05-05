using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxAdvSample
{
    public class Model
    {
        public Model(string name)
        {
            this.name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
        }
    }
}
