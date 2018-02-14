using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class GroupWu : IGroup
    {
        public void ShowGroup()
        {
            Console.WriteLine("{0} is 孙权",this.GetType().Name);
        }
    }
}
