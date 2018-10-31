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
        //List<ProductFather> productFatherList = new List<ProductFather>();
        List<List<ProductFather>> Lists = new List<List<ProductFather>>();
        //二者的区别
        /// <summary>
        /// 在创建仓库的时候，向仓库中添加货架
        /// </summary>
        /// <param name="lists"></param>
        /// list[0]存储和田大枣
        /// list[1]存储山西枣
        /// list[2]存储滩枣
        /// list[3]存储紫金枣
        /// list[4]存烟台苹果
        public CangKu()
        {
            Lists.Add(new List<ProductFather>());
            Lists.Add(new List<ProductFather>());
            Lists.Add(new List<ProductFather>());
            Lists.Add(new List<ProductFather>());
            Lists.Add(new List<ProductFather>());
        }
        /// <summary>
        /// 向用户展示货物（名称，数量，价钱）
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in Lists)
            {
                Console.WriteLine("我们仓库有"+item[0].Name+","+"\t"+"我们超市有"+item.Count+"个"+","+"\t"+"每个"+item[0].Price+"元");
            }
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType"></param>
        /// <param name="count"></param>
        /// 货物的类型和数量
        public  void JinPros(string strType,int count) 
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "HeTianDaZao":
                        Lists[0].Add(new HeTianDaZao(Guid.NewGuid().ToString(), 20, "和田大枣"));
                        break;
                    case "ShanxiZao":
                        Lists[1].Add(new ShanxiZao(Guid.NewGuid().ToString(), 10, "山西枣"));
                        break;
                    case "TanZao":
                        Lists[2].Add(new TanZao(Guid.NewGuid().ToString(), 15, "滩枣"));
                        break;
                    case "ZiJinZao":
                        Lists[3].Add(new ZiJinZao(Guid.NewGuid().ToString(), 18, "紫金枣"));
                        break;
                    case "YanTaiApple":
                        Lists[4].Add(new YanTaiApple(Guid.NewGuid().ToString(),5, "烟台苹果"));
                        break;
                }
            }
        }
        /// <summary>
        /// 从仓库中提取货物
        /// </summary>
        /// <param name="strType"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public ProductFather[] QuPros(string strType,int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {

                 //库存为0的情况未写
                    case "HeTianDaZao":
                        pros[i] = Lists[0][0];
                    Lists[0].RemoveAt(0);
                    break;
             
                    
                    case "ShanxiZao":
                        pros[i] = Lists[1][0];
                        Lists[1].RemoveAt(0);
                        break;
                    case "TanZao":
                        pros[i] = Lists[2][0];
                        Lists[2].RemoveAt(0);
                        break;
                    case "ZiJinZao":
                        pros[i] = Lists[3][0];
                        Lists[3].RemoveAt(0);
                        break;
                    case "YanTaiApple":
                        pros[i] = Lists[4][0];
                        Lists[4].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }

    }
}
