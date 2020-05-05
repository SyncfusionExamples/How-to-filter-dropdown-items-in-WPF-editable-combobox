using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxAdvSample
{
    public class ViewModel
    {
        public List<Model> List
        {
            get;
            set;
        }

        public ViewModel()
        {
            List = new List<Model>();
            List.Add(new Model("Alaska"));
            List.Add(new Model("Arizona"));
            List.Add(new Model("Colorado"));
            List.Add(new Model("Connecticut"));
            List.Add(new Model("Delaware"));
            List.Add(new Model("Florida"));
            List.Add(new Model("Georgia"));
            List.Add(new Model("Hawaii"));
            List.Add(new Model("Idaho"));
            List.Add(new Model("Illinois"));
            List.Add(new Model("Indiana"));
            List.Add(new Model("Iowa"));
            List.Add(new Model("Kansas"));
        }
    }
}
