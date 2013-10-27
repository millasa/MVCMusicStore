namespace MvcMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderModelUpdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "Username");
            DropColumn("dbo.Orders", "FirstName");
            DropColumn("dbo.Orders", "LastName");
            DropColumn("dbo.Orders", "Address");
            DropColumn("dbo.Orders", "City");
            DropColumn("dbo.Orders", "State");
            DropColumn("dbo.Orders", "PostalCode");
            DropColumn("dbo.Orders", "Country");
            DropColumn("dbo.Orders", "Phone");
            DropColumn("dbo.Orders", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Orders", "Phone", c => c.String(nullable: false, maxLength: 24));
            AddColumn("dbo.Orders", "Country", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Orders", "PostalCode", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.Orders", "State", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Orders", "City", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Orders", "Address", c => c.String(nullable: false, maxLength: 70));
            AddColumn("dbo.Orders", "LastName", c => c.String(nullable: false, maxLength: 160));
            AddColumn("dbo.Orders", "FirstName", c => c.String(nullable: false, maxLength: 160));
            AddColumn("dbo.Orders", "Username", c => c.String());
        }
    }
}
