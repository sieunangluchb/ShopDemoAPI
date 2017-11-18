namespace ShopDemoAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTagField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PRODUCTS", "TAGS", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PRODUCTS", "TAGS");
        }
    }
}
