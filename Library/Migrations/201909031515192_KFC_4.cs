namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KFC_4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Chicken", "Product_Id", "dbo.Dishes");
            DropForeignKey("dbo.Desserts", "Product_Id", "dbo.Dishes");
            DropForeignKey("dbo.Drinks", "Product_Id", "dbo.Dishes");
            DropForeignKey("dbo.Sandwiches", "Product_Id", "dbo.Dishes");
            DropIndex("dbo.Chicken", new[] { "Product_Id" });
            DropIndex("dbo.Desserts", new[] { "Product_Id" });
            DropIndex("dbo.Drinks", new[] { "Product_Id" });
            DropIndex("dbo.Sandwiches", new[] { "Product_Id" });
            AddColumn("dbo.Dishes", "Type_Id", c => c.Int(nullable: false));
            DropTable("dbo.Chicken");
            DropTable("dbo.Desserts");
            DropTable("dbo.Drinks");
            DropTable("dbo.Sandwiches");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Sandwiches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Desserts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Chicken",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Dishes", "Type_Id");
            CreateIndex("dbo.Sandwiches", "Product_Id");
            CreateIndex("dbo.Drinks", "Product_Id");
            CreateIndex("dbo.Desserts", "Product_Id");
            CreateIndex("dbo.Chicken", "Product_Id");
            AddForeignKey("dbo.Sandwiches", "Product_Id", "dbo.Dishes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Drinks", "Product_Id", "dbo.Dishes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Desserts", "Product_Id", "dbo.Dishes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Chicken", "Product_Id", "dbo.Dishes", "Id", cascadeDelete: true);
        }
    }
}
