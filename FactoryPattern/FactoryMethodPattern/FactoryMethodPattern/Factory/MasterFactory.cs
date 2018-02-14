using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 法师工厂类
    /// </summary>
    class MasterFactory
    {
        public static IRace CreateInstance()
        {
            IRace race = null;
            race = new Master();
            race.ShowKing();
            return race;
        }
    }
}
