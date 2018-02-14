using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class GroupShu : IGroup
    {
        public void ShowGroup()
        {
            Console.WriteLine("{0} is 刘备",this.GetType().Name);
        }
    }
}
