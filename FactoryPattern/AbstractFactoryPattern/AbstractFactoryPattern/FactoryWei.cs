using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class FactoryWei : AbstractFactory
    {
        public override IGroup CreateGroup()
        {
            return new GroupWei();
        }
        public override IGenerals CreateGenerals()
        {
            return new GeneralsWei();
        }
    }
}
