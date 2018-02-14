using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 简单工厂模式：工厂类一般是使用静态方法，通过接收的参数不同来返回不同的对象实例。不修改代码的话，是无法扩展的
    /// 优点：客户端可以免除直接创建产品对象的责任，而仅仅是“消费”产品。简单工厂模式通过这种做法实现了对责任的分割
    /// 缺点：由于工厂类集中了所有实例的创建逻辑，违反了高内聚责任分配原则，将全部创建逻辑集中到了一个工厂类中；它所能创建的类只能是事先考虑到的，如果需要添加新的类，则就需要改变工厂类了
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IRace warrior = Factory.CreateInstance(Factory.RaceType.Warrior);
            warrior.ShowKing();

            IRace master = Factory.CreateInstance(Factory.RaceType.Master);
            master.ShowKing();

            Console.Read();
        }
    }
}
