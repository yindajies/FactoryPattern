using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class GeneralsShu : IGenerals
    {
        public void ShowGenerals()
        {
            Console.WriteLine("{0}:张飞，关羽",this.GetType().Name);
        }
    }
}
