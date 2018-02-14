using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 法师类
    /// </summary>
    class Master : IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("The King for Master is Victor");
        }
    }
}
