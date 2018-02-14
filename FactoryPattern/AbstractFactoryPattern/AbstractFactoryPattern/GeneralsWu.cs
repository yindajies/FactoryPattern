using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class GeneralsWu : IGenerals
    {
        public void ShowGenerals()
        {
            Console.WriteLine("{0}:黄盖，甘宁", this.GetType().Name);
        }
    }
}
