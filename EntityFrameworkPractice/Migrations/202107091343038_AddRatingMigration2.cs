namespace EntityFrameworkPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Rating2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Rating2");
        }
    }
}
