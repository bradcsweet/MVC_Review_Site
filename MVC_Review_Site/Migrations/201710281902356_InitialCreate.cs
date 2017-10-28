namespace MVC_Review_Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BodyOfWater = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        WeatherType = c.String(),
                        WaterCondition = c.String(),
                        StoneAvailability = c.Int(nullable: false),
                        AverageSkip = c.Int(nullable: false),
                        Comment = c.String(maxLength: 140),
                        OverallReview = c.Int(nullable: false),
                        LocationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.LocationID, cascadeDelete: true)
                .Index(t => t.LocationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "LocationID", "dbo.Locations");
            DropIndex("dbo.Reviews", new[] { "LocationID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Locations");
        }
    }
}
