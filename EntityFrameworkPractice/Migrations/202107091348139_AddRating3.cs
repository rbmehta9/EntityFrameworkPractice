namespace EntityFrameworkPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRating3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Rating3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Rating3");
        }
    }
}
