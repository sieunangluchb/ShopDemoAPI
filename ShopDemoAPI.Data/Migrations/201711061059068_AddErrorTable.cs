namespace ShopDemoAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddErrorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ERRORS",
                c => new
                    {
                        ID_ERROR = c.Int(nullable: false, identity: true),
                        MESSAGE = c.String(),
                        STACKTRACE = c.String(),
                        CREATEDDATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_ERROR);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ERRORS");
        }
    }
}
