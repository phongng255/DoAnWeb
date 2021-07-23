namespace DAW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.String(nullable: false, maxLength: 128),
                        Amount = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ShoeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CustomerId)
                .ForeignKey("dbo.Shoes", t => t.ShoeId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ShoeId);
            
            CreateTable(
                "dbo.Shoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Color = c.String(),
                        Size = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ShoeId", "dbo.Shoes");
            DropForeignKey("dbo.Shoes", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Shoes", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.AspNetUsers");
            DropIndex("dbo.Shoes", new[] { "BrandId" });
            DropIndex("dbo.Shoes", new[] { "CategoryId" });
            DropIndex("dbo.Orders", new[] { "ShoeId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.Categories");
            DropTable("dbo.Brands");
            DropTable("dbo.Shoes");
            DropTable("dbo.Orders");
        }
    }
}
