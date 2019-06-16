namespace Nightmarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Booth",
                c => new
                    {
                        BoothId = c.Int(nullable: false, identity: true),
                        BoothName = c.String(),
                        BoothLocation = c.String(),
                        Operator = c.String(),
                        BoothIntroduction = c.String(),
                        CommodityId = c.Int(nullable: false),
                        NightmarketId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BoothId);
            
            CreateTable(
                "dbo.Commodity",
                c => new
                    {
                        CommodityId = c.Int(nullable: false, identity: true),
                        CommodityName = c.String(),
                        CommodityPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CommodityClassification = c.String(),
                        BoothId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommodityId);
            
            CreateTable(
                "dbo.Message",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        MessageDate = c.DateTime(nullable: false),
                        MessageContent = c.String(),
                        MemberId = c.Int(nullable: false),
                        CommodityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.Commodity", t => t.CommodityId, cascadeDelete: true)
                .ForeignKey("dbo.Member", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId)
                .Index(t => t.CommodityId);
            
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Gender = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.MemberId);
            
            CreateTable(
                "dbo.Score",
                c => new
                    {
                        ScoreId = c.Int(nullable: false, identity: true),
                        ScoreDate = c.DateTime(nullable: false),
                        ScoreGrade = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        CommodityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScoreId)
                .ForeignKey("dbo.Commodity", t => t.CommodityId, cascadeDelete: true)
                .ForeignKey("dbo.Member", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId)
                .Index(t => t.CommodityId);
            
            CreateTable(
                "dbo.NightMarket",
                c => new
                    {
                        NightmarketId = c.Int(nullable: false, identity: true),
                        NightmarketName = c.String(),
                        NightmarketIntroduction = c.String(),
                    })
                .PrimaryKey(t => t.NightmarketId);
            
            CreateTable(
                "dbo.CommodityBooth",
                c => new
                    {
                        Commodity_CommodityId = c.Int(nullable: false),
                        Booth_BoothId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Commodity_CommodityId, t.Booth_BoothId })
                .ForeignKey("dbo.Commodity", t => t.Commodity_CommodityId, cascadeDelete: true)
                .ForeignKey("dbo.Booth", t => t.Booth_BoothId, cascadeDelete: true)
                .Index(t => t.Commodity_CommodityId)
                .Index(t => t.Booth_BoothId);
            
            CreateTable(
                "dbo.NightMarketBooth",
                c => new
                    {
                        NightMarket_NightmarketId = c.Int(nullable: false),
                        Booth_BoothId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.NightMarket_NightmarketId, t.Booth_BoothId })
                .ForeignKey("dbo.NightMarket", t => t.NightMarket_NightmarketId, cascadeDelete: true)
                .ForeignKey("dbo.Booth", t => t.Booth_BoothId, cascadeDelete: true)
                .Index(t => t.NightMarket_NightmarketId)
                .Index(t => t.Booth_BoothId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NightMarketBooth", "Booth_BoothId", "dbo.Booth");
            DropForeignKey("dbo.NightMarketBooth", "NightMarket_NightmarketId", "dbo.NightMarket");
            DropForeignKey("dbo.Score", "MemberId", "dbo.Member");
            DropForeignKey("dbo.Score", "CommodityId", "dbo.Commodity");
            DropForeignKey("dbo.Message", "MemberId", "dbo.Member");
            DropForeignKey("dbo.Message", "CommodityId", "dbo.Commodity");
            DropForeignKey("dbo.CommodityBooth", "Booth_BoothId", "dbo.Booth");
            DropForeignKey("dbo.CommodityBooth", "Commodity_CommodityId", "dbo.Commodity");
            DropIndex("dbo.NightMarketBooth", new[] { "Booth_BoothId" });
            DropIndex("dbo.NightMarketBooth", new[] { "NightMarket_NightmarketId" });
            DropIndex("dbo.CommodityBooth", new[] { "Booth_BoothId" });
            DropIndex("dbo.CommodityBooth", new[] { "Commodity_CommodityId" });
            DropIndex("dbo.Score", new[] { "CommodityId" });
            DropIndex("dbo.Score", new[] { "MemberId" });
            DropIndex("dbo.Message", new[] { "CommodityId" });
            DropIndex("dbo.Message", new[] { "MemberId" });
            DropTable("dbo.NightMarketBooth");
            DropTable("dbo.CommodityBooth");
            DropTable("dbo.NightMarket");
            DropTable("dbo.Score");
            DropTable("dbo.Member");
            DropTable("dbo.Message");
            DropTable("dbo.Commodity");
            DropTable("dbo.Booth");
        }
    }
}
