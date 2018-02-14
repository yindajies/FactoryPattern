using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 工厂方法模式：针对每一种产品提供一个工厂类。通过不同的工厂实例来创建不同的产品实例。在同一等级结构中，支持增加任意产品
    /// 优点：允许系统在不修改具体工厂角色的情况下引进新产品
    /// 缺点：由于每加一个产品，就需要加一个产品工厂的类，增加了额外的开发量
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            IRace warrior = WarriorFactory.CreateInstance();

            IRace master = MasterFactory.CreateInstance();
            Console.Read();
        }
    }
}
