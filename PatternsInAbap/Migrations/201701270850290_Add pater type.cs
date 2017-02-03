namespace PatternsInAbap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addpatertype : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patterns", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patterns", "Type");
        }
    }
}
