namespace PBL3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBmig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AREAs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PCs",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 6),
                        AreaID = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AREAs", t => t.AreaID, cascadeDelete: true)
                .ForeignKey("dbo.PC_STATUS", t => t.StatusID, cascadeDelete: true)
                .Index(t => t.AreaID)
                .Index(t => t.StatusID);
            
            CreateTable(
                "dbo.PC_STATUS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.USERS",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 18),
                        PWD = c.String(nullable: false, maxLength: 18),
                        RoleID = c.Int(nullable: false),
                        UsingPC = c.String(maxLength: 6),
                        RemainingMoney = c.Double(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        LastLogin = c.DateTime(nullable: false),
                        OnlineStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserName)
                .ForeignKey("dbo.PCs", t => t.UsingPC)
                .ForeignKey("dbo.ROLES", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID)
                .Index(t => t.UsingPC);
            
            CreateTable(
                "dbo.LOGIN_HISTORY",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 18),
                        PCID = c.String(maxLength: 6),
                        LoginTime = c.DateTime(nullable: false),
                        LogoutTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PCs", t => t.PCID)
                .ForeignKey("dbo.USERS", t => t.UserName, cascadeDelete: true)
                .Index(t => t.UserName)
                .Index(t => t.PCID);
            
            CreateTable(
                "dbo.RECEIPTs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 18),
                        TotalPrice = c.Double(nullable: false),
                        FormedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.USERS", t => t.UserName)
                .Index(t => t.UserName);
            
            CreateTable(
                "dbo.RECEIPT_ITEM",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ReceiptID = c.Int(nullable: false),
                        ServiceID = c.String(maxLength: 128),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RECEIPTs", t => t.ReceiptID, cascadeDelete: true)
                .ForeignKey("dbo.SERVs", t => t.ServiceID)
                .Index(t => t.ReceiptID)
                .Index(t => t.ServiceID);
            
            CreateTable(
                "dbo.SERVs",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Unit = c.String(),
                        UnitPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CHAT_LOG",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        sender = c.String(maxLength: 18),
                        receiver = c.String(maxLength: 18),
                        msg = c.String(maxLength: 100),
                        SendTime = c.DateTime(nullable: false),
                        USERS_UserName = c.String(maxLength: 18),
                        USERS_UserName1 = c.String(maxLength: 18),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.USERS", t => t.receiver)
                .ForeignKey("dbo.USERS", t => t.sender)
                .ForeignKey("dbo.USERS", t => t.USERS_UserName)
                .ForeignKey("dbo.USERS", t => t.USERS_UserName1)
                .Index(t => t.sender)
                .Index(t => t.receiver)
                .Index(t => t.USERS_UserName)
                .Index(t => t.USERS_UserName1);
            
            CreateTable(
                "dbo.ROLES",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CHAT_LOG", "USERS_UserName1", "dbo.USERS");
            DropForeignKey("dbo.USERS", "RoleID", "dbo.ROLES");
            DropForeignKey("dbo.CHAT_LOG", "USERS_UserName", "dbo.USERS");
            DropForeignKey("dbo.CHAT_LOG", "sender", "dbo.USERS");
            DropForeignKey("dbo.CHAT_LOG", "receiver", "dbo.USERS");
            DropForeignKey("dbo.RECEIPTs", "UserName", "dbo.USERS");
            DropForeignKey("dbo.RECEIPT_ITEM", "ServiceID", "dbo.SERVs");
            DropForeignKey("dbo.RECEIPT_ITEM", "ReceiptID", "dbo.RECEIPTs");
            DropForeignKey("dbo.USERS", "UsingPC", "dbo.PCs");
            DropForeignKey("dbo.LOGIN_HISTORY", "UserName", "dbo.USERS");
            DropForeignKey("dbo.LOGIN_HISTORY", "PCID", "dbo.PCs");
            DropForeignKey("dbo.PCs", "StatusID", "dbo.PC_STATUS");
            DropForeignKey("dbo.PCs", "AreaID", "dbo.AREAs");
            DropIndex("dbo.CHAT_LOG", new[] { "USERS_UserName1" });
            DropIndex("dbo.CHAT_LOG", new[] { "USERS_UserName" });
            DropIndex("dbo.CHAT_LOG", new[] { "receiver" });
            DropIndex("dbo.CHAT_LOG", new[] { "sender" });
            DropIndex("dbo.RECEIPT_ITEM", new[] { "ServiceID" });
            DropIndex("dbo.RECEIPT_ITEM", new[] { "ReceiptID" });
            DropIndex("dbo.RECEIPTs", new[] { "UserName" });
            DropIndex("dbo.LOGIN_HISTORY", new[] { "PCID" });
            DropIndex("dbo.LOGIN_HISTORY", new[] { "UserName" });
            DropIndex("dbo.USERS", new[] { "UsingPC" });
            DropIndex("dbo.USERS", new[] { "RoleID" });
            DropIndex("dbo.PCs", new[] { "StatusID" });
            DropIndex("dbo.PCs", new[] { "AreaID" });
            DropTable("dbo.ROLES");
            DropTable("dbo.CHAT_LOG");
            DropTable("dbo.SERVs");
            DropTable("dbo.RECEIPT_ITEM");
            DropTable("dbo.RECEIPTs");
            DropTable("dbo.LOGIN_HISTORY");
            DropTable("dbo.USERS");
            DropTable("dbo.PC_STATUS");
            DropTable("dbo.PCs");
            DropTable("dbo.AREAs");
        }
    }
}
