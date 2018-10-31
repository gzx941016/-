using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统之商品类
{/// <summary>
/// 不打折，该多少就多少
/// </summary>
    class CalNomal:CalFather
    {
        public override double GetTotalMoney(double RealMoney)
        {
            return RealMoney;
        }
    }
}
