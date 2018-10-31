using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统之商品类
{
    /// <summary>
    /// 买m元送n元
    /// </summary>
    class CalMN:CalFather
    {
        public double M
        {
            get;
            set;
        }
        public double N
        {
            get;
            set;
        }
        public CalMN(double m,double n)
        {
            this.M = m;
            this.N = n;
        }
        public override double GetTotalMoney(double RealMoney)
        {
            if (RealMoney >= this.M)
            {
                return RealMoney - (int)(RealMoney / this.M) * this.N;
            }
            else
            {
                return RealMoney;
            }
        }

    }
}
