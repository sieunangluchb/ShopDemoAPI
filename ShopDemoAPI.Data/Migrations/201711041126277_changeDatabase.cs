namespace ShopDemoAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDatabase : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.FOODTERS", newName: "FOOTERS");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.FOOTERS", newName: "FOODTERS");
        }
    }
}
