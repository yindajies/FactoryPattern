using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 抽象类
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract IGroup CreateGroup();
        public abstract IGenerals CreateGenerals();
    }
}
