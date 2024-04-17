namespace Nasiha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFullnameToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FullName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "FullName");
        }
    }
}
