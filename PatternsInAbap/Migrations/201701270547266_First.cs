namespace PatternsInAbap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Links",
                c => new
                    {
                        Url = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Url);
            
            CreateTable(
                "dbo.Patterns",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                        Code = c.String(),
                        Diagramme = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.PatternLinks",
                c => new
                    {
                        Pattern_Name = c.String(nullable: false, maxLength: 128),
                        Link_Url = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Pattern_Name, t.Link_Url })
                .ForeignKey("dbo.Patterns", t => t.Pattern_Name, cascadeDelete: true)
                .ForeignKey("dbo.Links", t => t.Link_Url, cascadeDelete: true)
                .Index(t => t.Pattern_Name)
                .Index(t => t.Link_Url);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatternLinks", "Link_Url", "dbo.Links");
            DropForeignKey("dbo.PatternLinks", "Pattern_Name", "dbo.Patterns");
            DropIndex("dbo.PatternLinks", new[] { "Link_Url" });
            DropIndex("dbo.PatternLinks", new[] { "Pattern_Name" });
            DropTable("dbo.PatternLinks");
            DropTable("dbo.Patterns");
            DropTable("dbo.Links");
        }
    }
}
