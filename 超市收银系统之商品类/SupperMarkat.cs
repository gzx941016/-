using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统之商品类
{
    class SupperMarkat
    {
        CangKu ck = new CangKu();

        /// <summary>
        /// 创建超市对象的时候，给超市的货架上导入货物
        /// </summary>
        public SupperMarkat()
        {
            ck.JinPros("HeTianDaZao", 1000);
            ck.JinPros("ShanxiZao", 1000);
            ck.JinPros("TanZao", 1000);
            ck.JinPros("ZiJinZao", 1000);
            ck.JinPros("YanTaiApple", 1000);

        }
        public void AskBuyying()
        {
            Console.WriteLine("欢迎光临猫七家超市");
            Console.WriteLine("请问您需要什么？我们有HeTianDaZao、ShanXiZao、TanZao、ZiJinZao、YanTaiApple");
            string strTP = Console.ReadLine();
            Console.WriteLine("请问您需要多少");
            int count = Convert.ToInt32(Console.ReadLine());

            
            ProductFather [] pros= ck.QuPros(strTP, count);

            //计算价钱
            double AllMoney = GetMoney(pros);
            Console.WriteLine("您总共应付{0}元",AllMoney);
            Console.WriteLine("请您选择打折方式：1--不打折  2--打九折  3--打85折  4--买300送50  5--买500送100");
            string InputXuan = Console.ReadLine();
            CalFather cal = GetCal(InputXuan);
           double DZMoney= cal.GetTotalMoney(AllMoney);
            

            Console.WriteLine("以下是您购买物品的信息");
            foreach (var item in pros)
            {
                Console.WriteLine("货物编号："+item.ID+"  货物名称："+item.Name+"   货物单价"+item.Price);
            }
            Console.WriteLine("购买数量：{0}",count);
            Console.WriteLine("打完折后，您应付{0}元", DZMoney);
        }

     
        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1":
                    cal = new CalNomal();
                    break;
                case "2":
                    cal = new CalRate(0.9);
                    break;
                case "3":
                    cal = new CalRate(0.85);
                    break;
                case "4":
                    cal = new CalMN(300, 50);
                    break;
                case "5":
                    cal = new CalMN(500, 100);
                    break;

            }
            return cal;
        }

        public double GetMoney(ProductFather [] pros)
        {
            double RealMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                RealMoney += pros[i].Price;
            }
            return RealMoney;
        }

        public void ShowPros()
        {
            ck.ShowPros();
        }
    }
}
