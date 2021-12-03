namespace Enity_Framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Unit = c.String(),
                        FoodCategoryId = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.FoodCategoryId, cascadeDelete: true)
                .Index(t => t.FoodCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "FoodCategoryId", "dbo.Categories");
            DropIndex("dbo.Foods", new[] { "FoodCategoryId" });
            DropTable("dbo.Foods");
            DropTable("dbo.Categories");
        }
    }
}
