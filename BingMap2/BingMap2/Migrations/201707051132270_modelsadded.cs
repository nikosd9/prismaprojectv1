namespace BingMap2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelsadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parameters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParameterName = c.String(),
                        ShipId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ships", t => t.ShipId, cascadeDelete: false)
                .Index(t => t.ShipId);
            
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShipName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ParameterValues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParameterValueNum = c.Double(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        ShipId = c.Int(nullable: false),
                        ParameterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Parameters", t => t.ParameterId, cascadeDelete: false)
                .ForeignKey("dbo.Ships", t => t.ShipId, cascadeDelete: false)
                .Index(t => t.ShipId)
                .Index(t => t.ParameterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParameterValues", "ShipId", "dbo.Ships");
            DropForeignKey("dbo.ParameterValues", "ParameterId", "dbo.Parameters");
            DropForeignKey("dbo.Parameters", "ShipId", "dbo.Ships");
            DropIndex("dbo.ParameterValues", new[] { "ParameterId" });
            DropIndex("dbo.ParameterValues", new[] { "ShipId" });
            DropIndex("dbo.Parameters", new[] { "ShipId" });
            DropTable("dbo.ParameterValues");
            DropTable("dbo.Ships");
            DropTable("dbo.Parameters");
        }
    }
}
