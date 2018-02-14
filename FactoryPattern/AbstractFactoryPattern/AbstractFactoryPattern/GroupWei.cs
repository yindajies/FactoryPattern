using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class GroupWei:IGroup
    {
        public void ShowGroup()
        {
            Console.WriteLine("{0} is 曹操",this.GetType().Name);
        }
    }
}
