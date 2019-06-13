using Nightmarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nightmarket.DAL
{
    public class NightmarketInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NightmarketContext>
    {
        protected override void Seed(NightmarketContext context)
        {
            var students = new List<NightMarket>
            {
            // 2個夜市
            new NightMarket { NightmarketName = "花園夜市", NightmarketIntroduction = "每週四、六、日台南最具指標性的夜市，若想逛完整個「花園夜市」至少得花費兩個小時以上的時間，是來到台南市夜晚消磨時間的休閒好去處。" },
            new NightMarket { NightmarketName = "圍仔內夜市", NightmarketIntroduction = "每週二、五，在文賢國小旁邊，好吃好喝種類多多。" }
            };

            students.ForEach(s => context.NightMarkets.Add(s));
            context.SaveChanges();
            var courses = new List<Booth>
            {
            // 20個攤位
             new Booth{BoothName="三媽臭豆腐",BoothLocation="1 號攤",Operator="顏卉婕",BoothIntroduction="我們主打好臭的臭豆腐",CommodityId=1,NightmarketId=1},
             new Booth{BoothName="大腸包小腸",BoothLocation="2 號攤",Operator="戴君竹",BoothIntroduction="我們主打巨大化大腸包小腸",CommodityId=2,NightmarketId=1},
             new Booth{BoothName="搖搖珍珠黑糖牛奶",BoothLocation="3 號攤",Operator="杜素真",BoothIntroduction="我們主打好喝的珍珠黑糖牛奶",CommodityId=3,NightmarketId=1},
             new Booth{BoothName="水果果汁",BoothLocation="4 號攤",Operator="陳譯賢",BoothIntroduction="我們主打新鮮現打果汁",CommodityId=4,NightmarketId=1},
             new Booth{BoothName="帥性牛排店",BoothLocation="5 號攤",Operator="皮卡丘",BoothIntroduction="我們主打帥哥店員",CommodityId=5,NightmarketId=1},
             new Booth{BoothName="蝦了嗎?蚵仔煎",BoothLocation="6 號攤",Operator="宋妍希",BoothIntroduction="我們主打鮮蝦蚵仔煎",CommodityId=6,NightmarketId=1},
             new Booth{BoothName="冷阿!女裝店",BoothLocation="7 號攤",Operator="陳天仁",BoothIntroduction="我們主打寒流女裝",CommodityId=7,NightmarketId=1},
             new Booth{BoothName="帥氣男裝店",BoothLocation="8 號攤",Operator="周文淇",BoothIntroduction="我們主打讓男士穿了都變明星的高檔服裝",CommodityId=8,NightmarketId=1},
             new Booth{BoothName="好玩射氣球",BoothLocation="9 號攤",Operator="張庭萱",BoothIntroduction="我們主打射氣球，還可以跟關主比賽呦~",CommodityId=9,NightmarketId=1},
             new Booth{BoothName="不中麻將",BoothLocation="10 號攤",Operator="錢帥君",BoothIntroduction="我們主打讓你輸到脫褲的麻將",CommodityId=10,NightmarketId=1},
             new Booth{BoothName="好吃大腸包小腸",BoothLocation="11 號攤",Operator="寇德馨",BoothIntroduction="我們主打好吃的大腸包小腸",CommodityId=11,NightmarketId=2},
             new Booth{BoothName="阿美米血糕",BoothLocation="12 號攤",Operator="丁小芹",BoothIntroduction="我們主打香香的米血糕",CommodityId=12,NightmarketId=2},
             new Booth{BoothName="蔬菜果汁",BoothLocation="13 號攤",Operator="劉品言",BoothIntroduction="我們主打好喝的蔬菜果汁",CommodityId=13,NightmarketId=2},
             new Booth{BoothName="嘿!甘蔗汁",BoothLocation="14 號攤",Operator="卓毓彤",BoothIntroduction="我們主打可以吃甘蔗甘蔗汁",CommodityId=14,NightmarketId=2},
             new Booth{BoothName="蝦密蚵仔煎",BoothLocation="15 號攤",Operator="馮媛甄",BoothIntroduction="我們主打讓你永遠都知道吃到什麼口味的痾蚵仔煎",CommodityId=15,NightmarketId=2},
             new Booth{BoothName="hotpot小火鍋",BoothLocation="16 號攤",Operator="房思瑜",BoothIntroduction="我們主打提供免費冰淇淋吃到飽",CommodityId=16,NightmarketId=2},
             new Booth{BoothName="oop!男裝店",BoothLocation="17 號攤",Operator="夏如芝",BoothIntroduction="我們主打手工訂製男裝",CommodityId=17,NightmarketId=2},
             new Booth{BoothName="NICK鞋店",BoothLocation="18 號攤",Operator="廖麗君",BoothIntroduction="我們主打運動鞋",CommodityId=18,NightmarketId=2},
             new Booth{BoothName="包中麻將",BoothLocation="19 號攤",Operator="方妍心",BoothIntroduction="我們主打讓你贏死的麻將",CommodityId=19,NightmarketId=2},
             new Booth{BoothName="OK彈珠檯",BoothLocation="20 號攤",Operator="宋季韋",BoothIntroduction="我們主打讓你贏得OK輸得OK",CommodityId=20,NightmarketId=2}
            };

            courses.ForEach(s => context.Booths.Add(s));
            context.SaveChanges();
            var enrollments = new List<Commodity>
            {
                new Commodity{CommodityName="臭豆腐",CommodityPrice=55,CommodityClassification="點心",BoothId=1},
                new Commodity{CommodityName="大腸包小腸",CommodityPrice=35,CommodityClassification="點心",BoothId=2},
                new Commodity{CommodityName="珍珠黑糖牛奶",CommodityPrice=65,CommodityClassification="飲品",BoothId=3},
                new Commodity{CommodityName="果汁",CommodityPrice=55,CommodityClassification="飲品",BoothId=4},
                new Commodity{CommodityName="牛排店",CommodityPrice=355,CommodityClassification="主食",BoothId=5},
                new Commodity{CommodityName="蚵仔煎",CommodityPrice=55,CommodityClassification="主食",BoothId=6},
                new Commodity{CommodityName="女裝店",CommodityPrice=155,CommodityClassification="生活用品",BoothId=7},
                new Commodity{CommodityName="男裝店",CommodityPrice=355,CommodityClassification="生活用品",BoothId=8},
                new Commodity{CommodityName="射氣球",CommodityPrice=55,CommodityClassification="娛樂",BoothId=9},
                new Commodity{CommodityName="麻將",CommodityPrice=655,CommodityClassification="娛樂",BoothId=10},
                new Commodity{CommodityName="大腸包小腸",CommodityPrice=25,CommodityClassification="點心",BoothId=11},
                new Commodity{CommodityName="米血糕",CommodityPrice=45,CommodityClassification="點心",BoothId=12},
                new Commodity{CommodityName="果汁",CommodityPrice=60,CommodityClassification="飲品",BoothId=13},
                new Commodity{CommodityName="甘蔗汁",CommodityPrice=85,CommodityClassification="飲品",BoothId=14},
                new Commodity{CommodityName="蚵仔煎",CommodityPrice=60,CommodityClassification="主食",BoothId=15},
                new Commodity{CommodityName="小火鍋",CommodityPrice=125,CommodityClassification="主食",BoothId=16},
                new Commodity{CommodityName="男裝店",CommodityPrice=299,CommodityClassification="生活用品",BoothId=17},
                new Commodity{CommodityName="鞋店",CommodityPrice=255,CommodityClassification="生活用品",BoothId=18},
                new Commodity{CommodityName="麻將",CommodityPrice=200,CommodityClassification="娛樂",BoothId=19},
                new Commodity{CommodityName="彈珠檯",CommodityPrice=15,CommodityClassification="娛樂",BoothId=20},
            };
            enrollments.ForEach(s => context.Commoditys.Add(s));
            context.SaveChanges();
        }
    }
}