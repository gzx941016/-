using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统之商品类
{
    class CalRate:CalFather
    {

        public double Rate
        {
            get;
            set;
        }
        public CalRate(double rate)
        {
            this.Rate = rate;
        }
        public override double GetTotalMoney(double RealMoney)
        {
            return RealMoney * this.Rate;
        }
    }
}
