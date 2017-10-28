namespace MVC_Review_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCityState : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "CityState", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "CityState");
        }
    }
}
