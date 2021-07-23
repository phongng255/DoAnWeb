namespace DAW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shoes", "image", c => c.String());
            AddColumn("dbo.Brands", "image", c => c.String());
            AddColumn("dbo.Categories", "image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "image");
            DropColumn("dbo.Brands", "image");
            DropColumn("dbo.Shoes", "image");
        }
    }
}
