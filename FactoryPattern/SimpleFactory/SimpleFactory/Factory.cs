using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 工厂类
    /// </summary>
    public class Factory
    {
        public static IRace CreateInstance(RaceType raceType)
        {
            
            switch (raceType)
            {
                case RaceType.Warrior:
                    return new Warrior();
                case RaceType.Master:
                    return new Master();
                default:
                    throw new Exception("wrong raceType");
            }
        }
        public enum RaceType
        {
            Warrior,
            Master
        }

    }
    
}
