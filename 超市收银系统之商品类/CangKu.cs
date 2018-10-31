using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统之商品类
{
    class CangKu
    {
        //存储货物(存储父类，赋值子类类型，屏蔽各个子类的差异)
        //List<HeTianDaZao> hetianList = new List<HeTianDaZao>();
        //List<ShanxiZao> shanxiZaoList = new List<ShanxiZao>();
        //List<TanZao> tanZaoList = new List<TanZao>();
        //List<ZiJinZao> ziJinZaoList = new List<ZiJinZao>();
        //List<YanTaiApple> yanTaiAppleList = new List<YanTaiApple>();
        List<ProductFather> productFatherList = new List<ProductFather>();
        List<List<ProductFather>> Lists = new List<List<ProductFather>>();
        //二者的区别

    }
}
