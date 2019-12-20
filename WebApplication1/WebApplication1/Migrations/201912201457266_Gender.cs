namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Gender", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Gender");
        }
    }
}
