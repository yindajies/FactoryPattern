using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class FactoryShu:AbstractFactory
    {
        public override IGroup CreateGroup()
        {
            return new GroupShu();
        }
        public override IGenerals CreateGenerals()
        {
            return new GeneralsShu();
        }
    }
}
