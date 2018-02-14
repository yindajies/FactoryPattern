using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 战士工厂类
    /// </summary>
    class WarriorFactory
    {
        public static IRace CreateInstance()
        {
            IRace race = null;
            race = new Warrior();
            race.ShowKing();
            return race;
        }
    }
}
