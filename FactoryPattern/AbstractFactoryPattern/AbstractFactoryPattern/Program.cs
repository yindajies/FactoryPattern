using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 抽象工厂模式：多个抽象产品类，每个抽象产品类可以派生出多个具体产品类。一个抽象工厂类，可以派生出多个具体工厂类。每个具体工厂类可以创建多个具体产品类的实例
    /// 优点：向客户端提供一个接口，使得客户端在不必指定产品具体类型的情况下，创建多个产品族中的产品对象
    /// 缺点：增加新的产品等级结构很复杂，需要修改抽象工厂和所有的具体工厂类，对“开闭原则”的支持呈现倾斜性
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new FactoryShu();
            IGroup groupShu = factory.CreateGroup();
            IGenerals genealsShu = factory.CreateGenerals();
            groupShu.ShowGroup();
            genealsShu.ShowGenerals();

            AbstractFactory factory2 = new FactoryWu();
            IGroup groupWU = factory2.CreateGroup();
            IGenerals generalsWu = factory2.CreateGenerals();
            groupWU.ShowGroup();
            generalsWu.ShowGenerals();

            AbstractFactory factory3 = new FactoryWei();
            IGroup groupWei = factory3.CreateGroup();
            IGenerals generalsWei = factory3.CreateGenerals();
            groupWei.ShowGroup();
            generalsWei.ShowGenerals();

            Console.Read();
        }
    }
}
