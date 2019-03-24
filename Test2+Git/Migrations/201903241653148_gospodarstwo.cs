namespace Test2_Git.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gospodarstwo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Gospodarstwo", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "Ma_gospodarstwo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Ma_gospodarstwo", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "Gospodarstwo");
        }
    }
}
