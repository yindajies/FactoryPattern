using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class FactoryWu : AbstractFactory
    {
        public override IGroup CreateGroup()
        {
            return new GroupWu();
        }
        public override IGenerals CreateGenerals()
        {
            return new GeneralsWu();
        }
    }
}
