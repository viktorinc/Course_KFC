namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KFC_3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chicken",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dishes", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Desserts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dishes", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Drinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dishes", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Sandwiches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dishes", t => t.Product_Id, cascadeDelete: true)
                .Index(t => t.Product_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sandwiches", "Product_Id", "dbo.Dishes");
            DropForeignKey("dbo.Drinks", "Product_Id", "dbo.Dishes");
            DropForeignKey("dbo.Desserts", "Product_Id", "dbo.Dishes");
            DropForeignKey("dbo.Chicken", "Product_Id", "dbo.Dishes");
            DropIndex("dbo.Sandwiches", new[] { "Product_Id" });
            DropIndex("dbo.Drinks", new[] { "Product_Id" });
            DropIndex("dbo.Desserts", new[] { "Product_Id" });
            DropIndex("dbo.Chicken", new[] { "Product_Id" });
            DropTable("dbo.Sandwiches");
            DropTable("dbo.Drinks");
            DropTable("dbo.Desserts");
            DropTable("dbo.Chicken");
        }
    }
}
