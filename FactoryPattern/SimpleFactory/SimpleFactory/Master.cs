using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 法师类
    /// </summary>
    public class Master:IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("The King for Master is Victor");
        }
    }
}
