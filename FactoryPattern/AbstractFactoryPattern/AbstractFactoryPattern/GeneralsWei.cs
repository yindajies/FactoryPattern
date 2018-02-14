using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class GeneralsWei:IGenerals
    {
        public void ShowGenerals()
        {
            Console.WriteLine("{0}:典韦，张辽", this.GetType().Name);
        }
    }
}
