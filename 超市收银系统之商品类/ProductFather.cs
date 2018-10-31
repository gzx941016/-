using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统之商品类
{
    class ProductFather
    {

        public double Price
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public double Count
        {
            get;
            set;
        }
public ProductFather(string id,double price,double count)
        {
            this.ID = id;
            this.Price = price;
            this.Count = count;
        }


    }
}
