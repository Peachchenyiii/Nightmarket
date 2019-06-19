namespace Nightmarket.Migrations
{
    using Nightmarket.DAL;
    using Nightmarket.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Nightmarket.DAL.NightmarketContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Nightmarket.DAL.NightmarketContext";
        }

        protected override void Seed(Nightmarket.DAL.NightmarketContext context)
        {
            //  This method will be called after migrating to the latest version.

            ////  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //NightmarketInitializer.Seed(context);
            var students = new List<NightMarket>
            {
            // 2�ө]��
            new NightMarket { NightmarketName = "���]��", NightmarketIntroduction = "�C�g�|�B���B��x�n�̨���Щʪ��]���A�Y�Q�}����ӡu���]���v�ܤֱo��O��Ӥp�ɥH�W���ɶ��A�O�Ө�x�n���]�߮��i�ɶ����𶢦n�h�B�C" },
            new NightMarket { NightmarketName = "��J���]��", NightmarketIntroduction = "�C�g�G�B���A�b����p����A�n�Y�n�ܺ����h�h�C" }
            };

            students.ForEach(s => context.NightMarkets.Add(s));
            context.SaveChanges();
            var courses = new List<Booth>
            {
            // 20���u��
             new Booth{BoothName="�T���䨧�G",BoothLocation="1 ���u",Operator="�C�c��",BoothIntroduction="�ڭ̥D���n�䪺�䨧�G",CommodityId=1,NightmarketId=1},
             new Booth{BoothName="�j�z�]�p�z",BoothLocation="2 ���u",Operator="���g��",BoothIntroduction="�ڭ̥D�����j�Ƥj�z�]�p�z",CommodityId=2,NightmarketId=1},
             new Booth{BoothName="�n�n�ï]�¿}����",BoothLocation="3 ���u",Operator="�����u",BoothIntroduction="�ڭ̥D���n�ܪ��ï]�¿}����",CommodityId=3,NightmarketId=1},
             new Booth{BoothName="���G�G��",BoothLocation="4 ���u",Operator="��Ķ��",BoothIntroduction="�ڭ̥D���s�A�{���G��",CommodityId=4,NightmarketId=1},
             new Booth{BoothName="�өʤ��Ʃ�",BoothLocation="5 ���u",Operator="�֥d�C",BoothIntroduction="�ڭ̥D���ӭ�����",CommodityId=5,NightmarketId=1},
             new Booth{BoothName="���F��?�H�J��",BoothLocation="6 ���u",Operator="������",BoothIntroduction="�ڭ̥D���A���H�J��",CommodityId=6,NightmarketId=1},
             new Booth{BoothName="�N��!�k�˩�",BoothLocation="7 ���u",Operator="���Ѥ�",BoothIntroduction="�ڭ̥D���H�y�k��",CommodityId=7,NightmarketId=1},
             new Booth{BoothName="�Ӯ�k�˩�",BoothLocation="8 ���u",Operator="�P��N",BoothIntroduction="�ڭ̥D�����k�h��F���ܩ��P�����ɪA��",CommodityId=8,NightmarketId=1},
             new Booth{BoothName="�n���g��y",BoothLocation="9 ���u",Operator="�i�x��",BoothIntroduction="�ڭ̥D���g��y�A�٥i�H�����D������~",CommodityId=9,NightmarketId=1},
             new Booth{BoothName="�����±N",BoothLocation="10 ���u",Operator="���ӧg",BoothIntroduction="�ڭ̥D�����A����Ǫ��±N",CommodityId=10,NightmarketId=1},
             new Booth{BoothName="�n�Y�j�z�]�p�z",BoothLocation="11 ���u",Operator="�F�w��",BoothIntroduction="�ڭ̥D���n�Y���j�z�]�p�z",CommodityId=11,NightmarketId=2},
             new Booth{BoothName="�����̦�|",BoothLocation="12 ���u",Operator="�B�p��",BoothIntroduction="�ڭ̥D���������̦�|",CommodityId=12,NightmarketId=2},
             new Booth{BoothName="����G��",BoothLocation="13 ���u",Operator="�B�~��",BoothIntroduction="�ڭ̥D���n�ܪ�����G��",CommodityId=13,NightmarketId=2},
             new Booth{BoothName="�K!�̽���",BoothLocation="14 ���u",Operator="������",BoothIntroduction="�ڭ̥D���i�H�Y�̽��̽���",CommodityId=14,NightmarketId=2},
             new Booth{BoothName="���K�H�J��",BoothLocation="15 ���u",Operator="���D��",BoothIntroduction="�ڭ̥D�����A�û������D�Y�줰��f�����˳H�J��",CommodityId=15,NightmarketId=2},
             new Booth{BoothName="hotpot�p����",BoothLocation="16 ���u",Operator="�Ы��",BoothIntroduction="�ڭ̥D�����ѧK�O�B�N�O�Y�칡",CommodityId=16,NightmarketId=2},
             new Booth{BoothName="oop!�k�˩�",BoothLocation="17 ���u",Operator="�L�p��",BoothIntroduction="�ڭ̥D����u�q�s�k��",CommodityId=17,NightmarketId=2},
             new Booth{BoothName="NICK�c��",BoothLocation="18 ���u",Operator="���R�g",BoothIntroduction="�ڭ̥D���B�ʾc",CommodityId=18,NightmarketId=2},
             new Booth{BoothName="�]���±N",BoothLocation="19 ���u",Operator="�觰��",BoothIntroduction="�ڭ̥D�����AĹ�����±N",CommodityId=19,NightmarketId=2},
             new Booth{BoothName="OK�u�]�i",BoothLocation="20 ���u",Operator="���u��",BoothIntroduction="�ڭ̥D�����AĹ�oOK��oOK",CommodityId=20,NightmarketId=2}
            };

            courses.ForEach(s => context.Booths.Add(s));
            context.SaveChanges();
            var enrollments = new List<Commodity>
            {
                new Commodity{CommodityName="�䨧�G",CommodityPrice=55,CommodityClassification="�I��",BoothId=1},
                new Commodity{CommodityName="�j�z�]�p�z",CommodityPrice=35,CommodityClassification="�I��",BoothId=2},
                new Commodity{CommodityName="�ï]�¿}����",CommodityPrice=65,CommodityClassification="���~",BoothId=3},
                new Commodity{CommodityName="�G��",CommodityPrice=55,CommodityClassification="���~",BoothId=4},
                new Commodity{CommodityName="���Ʃ�",CommodityPrice=355,CommodityClassification="�D��",BoothId=5},
                new Commodity{CommodityName="�H�J��",CommodityPrice=55,CommodityClassification="�D��",BoothId=6},
                new Commodity{CommodityName="�k�˩�",CommodityPrice=155,CommodityClassification="�ͬ��Ϋ~",BoothId=7},
                new Commodity{CommodityName="�k�˩�",CommodityPrice=355,CommodityClassification="�ͬ��Ϋ~",BoothId=8},
                new Commodity{CommodityName="�g��y",CommodityPrice=55,CommodityClassification="�T��",BoothId=9},
                new Commodity{CommodityName="�±N",CommodityPrice=655,CommodityClassification="�T��",BoothId=10},
                new Commodity{CommodityName="�j�z�]�p�z",CommodityPrice=25,CommodityClassification="�I��",BoothId=11},
                new Commodity{CommodityName="�̦�|",CommodityPrice=45,CommodityClassification="�I��",BoothId=12},
                new Commodity{CommodityName="�G��",CommodityPrice=60,CommodityClassification="���~",BoothId=13},
                new Commodity{CommodityName="�̽���",CommodityPrice=85,CommodityClassification="���~",BoothId=14},
                new Commodity{CommodityName="�H�J��",CommodityPrice=50,CommodityClassification="�D��",BoothId=15},
                new Commodity{CommodityName="�p����",CommodityPrice=125,CommodityClassification="�D��",BoothId=16},
                new Commodity{CommodityName="�k�˩�",CommodityPrice=299,CommodityClassification="�ͬ��Ϋ~",BoothId=17},
                new Commodity{CommodityName="�c��",CommodityPrice=255,CommodityClassification="�ͬ��Ϋ~",BoothId=18},
                new Commodity{CommodityName="�±N",CommodityPrice=200,CommodityClassification="�T��",BoothId=19},
                new Commodity{CommodityName="�u�]�i",CommodityPrice=15,CommodityClassification="�T��",BoothId=20},
            };
            enrollments.ForEach(s => context.Commoditys.Add(s));
            context.SaveChanges();
        }
    }
}
