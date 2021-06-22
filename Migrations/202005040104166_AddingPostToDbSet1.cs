namespace Covid_19_Tracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPostToDbSet1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Heading", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Heading");
        }
    }
}
