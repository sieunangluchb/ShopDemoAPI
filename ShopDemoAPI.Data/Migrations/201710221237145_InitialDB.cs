namespace ShopDemoAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FOODTERS",
                c => new
                    {
                        ID_FOOTER = c.String(nullable: false, maxLength: 250, unicode: false),
                        CONTENT = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_FOOTER);
            
            CreateTable(
                "dbo.MENUGROUPS",
                c => new
                    {
                        ID_MENUGROUP = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.ID_MENUGROUP);
            
            CreateTable(
                "dbo.MENUS",
                c => new
                    {
                        ID_MENU = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 250),
                        URL = c.String(nullable: false, maxLength: 500),
                        DISPLAYORDER = c.Int(),
                        ID_MENUGROUP = c.Int(nullable: false),
                        TARGET = c.String(maxLength: 10, unicode: false),
                        STATUS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_MENU)
                .ForeignKey("dbo.MENUGROUPS", t => t.ID_MENUGROUP, cascadeDelete: true)
                .Index(t => t.ID_MENUGROUP);
            
            CreateTable(
                "dbo.ORDERDETAILS",
                c => new
                    {
                        ID_ORDER = c.Int(nullable: false),
                        ID_PRODUCT = c.Int(nullable: false),
                        QUANTITY = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ID_ORDER, t.ID_PRODUCT })
                .ForeignKey("dbo.ORDERS", t => t.ID_ORDER, cascadeDelete: true)
                .ForeignKey("dbo.PRODUCTS", t => t.ID_PRODUCT, cascadeDelete: true)
                .Index(t => t.ID_ORDER)
                .Index(t => t.ID_PRODUCT);
            
            CreateTable(
                "dbo.ORDERS",
                c => new
                    {
                        ID_ORDER = c.Int(nullable: false, identity: true),
                        CUSTOMERNAME = c.String(maxLength: 250),
                        CUSTOMERADDRESS = c.String(maxLength: 250),
                        CUSTOMEREMAIL = c.String(maxLength: 250),
                        CUSTOMERMOBILE = c.String(maxLength: 50, unicode: false),
                        CUSTOMERMESSAGE = c.String(maxLength: 250),
                        CREATEDDATE = c.DateTime(),
                        CREATEDBY = c.String(maxLength: 50, unicode: false),
                        PAYMENTMETHOD = c.String(maxLength: 250),
                        PAYMENTSTATUS = c.String(maxLength: 50),
                        STATUS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_ORDER);
            
            CreateTable(
                "dbo.PRODUCTS",
                c => new
                    {
                        ID_PRODUCT = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 250),
                        ALIAS = c.String(nullable: false, maxLength: 250, unicode: false),
                        ID_PRODUCTCATEGORY = c.Int(),
                        IMAGE = c.String(maxLength: 500),
                        MOREIMAGES = c.String(storeType: "xml"),
                        PRICE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PROMOTIONPRICE = c.Decimal(precision: 18, scale: 2),
                        WARRANTY = c.Int(),
                        DESCRIPTION = c.String(maxLength: 500),
                        CONTENT = c.String(),
                        HOMEFLAG = c.Boolean(),
                        HOTFLAG = c.Boolean(),
                        VIEWCOUNT = c.Int(),
                        METAKEYWORD = c.String(maxLength: 250),
                        METADESCRIPTION = c.String(maxLength: 250),
                        CREATEDDAY = c.DateTime(),
                        CREATEDBY = c.String(maxLength: 50, unicode: false),
                        UPDATEDDATE = c.DateTime(),
                        UPDATEDBY = c.String(maxLength: 50, unicode: false),
                        STATUS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_PRODUCT)
                .ForeignKey("dbo.PRODUCTCATEGORIES", t => t.ID_PRODUCTCATEGORY)
                .Index(t => t.ID_PRODUCTCATEGORY);
            
            CreateTable(
                "dbo.PRODUCTCATEGORIES",
                c => new
                    {
                        ID_PRODUCTCATEGORY = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 250),
                        ALIAS = c.String(nullable: false, maxLength: 250, unicode: false),
                        DESCRIPTION = c.String(maxLength: 500),
                        PARENT_ID = c.Int(),
                        DISPLAYORDER = c.Int(),
                        IMAGE = c.String(maxLength: 500),
                        HOMEFLAG = c.Boolean(),
                        METAKEYWORD = c.String(maxLength: 250),
                        METADESCRIPTION = c.String(maxLength: 250),
                        CREATEDDAY = c.DateTime(),
                        CREATEDBY = c.String(maxLength: 50, unicode: false),
                        UPDATEDDATE = c.DateTime(),
                        UPDATEDBY = c.String(maxLength: 50, unicode: false),
                        STATUS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_PRODUCTCATEGORY);
            
            CreateTable(
                "dbo.PAGES",
                c => new
                    {
                        ID_PAGE = c.Int(nullable: false, identity: true),
                        NAME = c.String(maxLength: 250),
                        CONTENT = c.String(),
                        METAKEYWORD = c.String(maxLength: 250),
                        METADESCRIPTION = c.String(maxLength: 250),
                        STATUS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_PAGE);
            
            CreateTable(
                "dbo.POSTCATEGORIES",
                c => new
                    {
                        ID_POSTCATEGORY = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 250),
                        ALIAS = c.String(nullable: false, maxLength: 250, unicode: false),
                        DESCRIPTION = c.String(maxLength: 500),
                        PARENT_ID = c.Int(),
                        DISPLAYORDER = c.Int(),
                        IMAGE = c.String(maxLength: 500),
                        HOMEFLAG = c.Boolean(),
                        METAKEYWORD = c.String(maxLength: 250),
                        METADESCRIPTION = c.String(maxLength: 250),
                        CREATEDDAY = c.DateTime(),
                        CREATEDBY = c.String(maxLength: 50, unicode: false),
                        UPDATEDDATE = c.DateTime(),
                        UPDATEDBY = c.String(maxLength: 50, unicode: false),
                        STATUS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_POSTCATEGORY);
            
            CreateTable(
                "dbo.POSTS",
                c => new
                    {
                        ID_POST = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 250),
                        ALIAS = c.String(nullable: false, maxLength: 250, unicode: false),
                        ID_POSTCATEGORY = c.Int(),
                        IMAGE = c.String(maxLength: 500),
                        DESCRIPTION = c.String(maxLength: 500),
                        CONTENT = c.String(),
                        HOMEFLAG = c.Boolean(),
                        HOTFLAG = c.Boolean(),
                        VIEWCOUNT = c.Int(),
                        METAKEYWORD = c.String(maxLength: 250),
                        METADESCRIPTION = c.String(maxLength: 250),
                        CREATEDDAY = c.DateTime(),
                        CREATEDBY = c.String(maxLength: 50, unicode: false),
                        UPDATEDDATE = c.DateTime(),
                        UPDATEDBY = c.String(maxLength: 50, unicode: false),
                        STATUS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_POST)
                .ForeignKey("dbo.POSTCATEGORIES", t => t.ID_POSTCATEGORY)
                .Index(t => t.ID_POSTCATEGORY);
            
            CreateTable(
                "dbo.POSTTAGS",
                c => new
                    {
                        ID_POST = c.Int(nullable: false),
                        ID_TAG = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ID_POST, t.ID_TAG })
                .ForeignKey("dbo.POSTS", t => t.ID_POST, cascadeDelete: true)
                .ForeignKey("dbo.TAGS", t => t.ID_TAG, cascadeDelete: true)
                .Index(t => t.ID_POST)
                .Index(t => t.ID_TAG);
            
            CreateTable(
                "dbo.TAGS",
                c => new
                    {
                        ID_TAG = c.String(nullable: false, maxLength: 50, unicode: false),
                        NAME = c.String(maxLength: 50),
                        TYPE = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID_TAG);
            
            CreateTable(
                "dbo.PRODUCTTAGS",
                c => new
                    {
                        ID_PRODUCT = c.Int(nullable: false),
                        ID_TAG = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.ID_PRODUCT, t.ID_TAG })
                .ForeignKey("dbo.PRODUCTS", t => t.ID_PRODUCT, cascadeDelete: true)
                .ForeignKey("dbo.TAGS", t => t.ID_TAG, cascadeDelete: true)
                .Index(t => t.ID_PRODUCT)
                .Index(t => t.ID_TAG);
            
            CreateTable(
                "dbo.SLIDES",
                c => new
                    {
                        ID_SLIDE = c.Int(nullable: false, identity: true),
                        NAME = c.String(nullable: false, maxLength: 50),
                        DESCRIPTION = c.String(maxLength: 250),
                        IMAGE = c.String(nullable: false, maxLength: 500),
                        URL = c.String(nullable: false, maxLength: 500),
                        DISPLAYORDER = c.Int(),
                        STATUS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_SLIDE);
            
            CreateTable(
                "dbo.SUPPORTONLINES",
                c => new
                    {
                        ID_SUPPORTONLINE = c.Int(nullable: false, identity: true),
                        NAME = c.String(maxLength: 250),
                        DEPARTMENT = c.String(maxLength: 250),
                        SKYPE = c.String(maxLength: 250),
                        MOBILE = c.String(maxLength: 250),
                        EMAIL = c.String(maxLength: 250),
                        YAHOO = c.String(maxLength: 250),
                        FACEBOOK = c.String(maxLength: 250),
                        STATUS = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID_SUPPORTONLINE);
            
            CreateTable(
                "dbo.SYSTEMCONFIGS",
                c => new
                    {
                        ID_SYSTEMCONFIG = c.Int(nullable: false, identity: true),
                        CODE = c.String(nullable: false, maxLength: 50, unicode: false),
                        VALUESTRING = c.String(maxLength: 250),
                        VALUEINT = c.Int(),
                    })
                .PrimaryKey(t => t.ID_SYSTEMCONFIG);
            
            CreateTable(
                "dbo.VISITORSTATISTICS",
                c => new
                    {
                        ID_VISITORSTATISTIC = c.Guid(nullable: false),
                        VISITEDDATE = c.DateTime(nullable: false),
                        IPADDRESS = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID_VISITORSTATISTIC);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PRODUCTTAGS", "ID_TAG", "dbo.TAGS");
            DropForeignKey("dbo.PRODUCTTAGS", "ID_PRODUCT", "dbo.PRODUCTS");
            DropForeignKey("dbo.POSTTAGS", "ID_TAG", "dbo.TAGS");
            DropForeignKey("dbo.POSTTAGS", "ID_POST", "dbo.POSTS");
            DropForeignKey("dbo.POSTS", "ID_POSTCATEGORY", "dbo.POSTCATEGORIES");
            DropForeignKey("dbo.ORDERDETAILS", "ID_PRODUCT", "dbo.PRODUCTS");
            DropForeignKey("dbo.PRODUCTS", "ID_PRODUCTCATEGORY", "dbo.PRODUCTCATEGORIES");
            DropForeignKey("dbo.ORDERDETAILS", "ID_ORDER", "dbo.ORDERS");
            DropForeignKey("dbo.MENUS", "ID_MENUGROUP", "dbo.MENUGROUPS");
            DropIndex("dbo.PRODUCTTAGS", new[] { "ID_TAG" });
            DropIndex("dbo.PRODUCTTAGS", new[] { "ID_PRODUCT" });
            DropIndex("dbo.POSTTAGS", new[] { "ID_TAG" });
            DropIndex("dbo.POSTTAGS", new[] { "ID_POST" });
            DropIndex("dbo.POSTS", new[] { "ID_POSTCATEGORY" });
            DropIndex("dbo.PRODUCTS", new[] { "ID_PRODUCTCATEGORY" });
            DropIndex("dbo.ORDERDETAILS", new[] { "ID_PRODUCT" });
            DropIndex("dbo.ORDERDETAILS", new[] { "ID_ORDER" });
            DropIndex("dbo.MENUS", new[] { "ID_MENUGROUP" });
            DropTable("dbo.VISITORSTATISTICS");
            DropTable("dbo.SYSTEMCONFIGS");
            DropTable("dbo.SUPPORTONLINES");
            DropTable("dbo.SLIDES");
            DropTable("dbo.PRODUCTTAGS");
            DropTable("dbo.TAGS");
            DropTable("dbo.POSTTAGS");
            DropTable("dbo.POSTS");
            DropTable("dbo.POSTCATEGORIES");
            DropTable("dbo.PAGES");
            DropTable("dbo.PRODUCTCATEGORIES");
            DropTable("dbo.PRODUCTS");
            DropTable("dbo.ORDERS");
            DropTable("dbo.ORDERDETAILS");
            DropTable("dbo.MENUS");
            DropTable("dbo.MENUGROUPS");
            DropTable("dbo.FOODTERS");
        }
    }
}
