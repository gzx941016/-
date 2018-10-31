using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统之商品类
{
    class Program
    {
        static void Main(string[] args)
        {
             
            //创建超市对象
            SupperMarkat sm = new SupperMarkat();
            //显示货物
            sm.ShowPros();
            //和用户交互
            sm.AskBuyying();
            Console.ReadKey();
        }
    }
}
