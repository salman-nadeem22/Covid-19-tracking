namespace Covid_19_Tracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPostToDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
