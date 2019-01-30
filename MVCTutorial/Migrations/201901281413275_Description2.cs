namespace MVCTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Description2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Description2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Description2");
        }
    }
}
