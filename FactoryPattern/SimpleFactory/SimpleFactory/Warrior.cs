using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 战士类
    /// </summary>
    public class Warrior:IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("The King for Warrior is Raven");
        }
    }
}
