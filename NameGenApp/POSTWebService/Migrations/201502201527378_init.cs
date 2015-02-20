namespace POSTWebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        PackageId = c.Int(nullable: false, identity: true),
                        SenderId = c.Int(nullable: false),
                        RecipientId = c.Int(nullable: false),
                        DestinationStreet = c.String(),
                        DestinationCity = c.String(),
                        DestinationPostalCode = c.String(),
                    })
                .PrimaryKey(t => t.PackageId)
                .ForeignKey("dbo.People", t => t.RecipientId)
                .ForeignKey("dbo.People", t => t.SenderId)
                .Index(t => t.SenderId)
                .Index(t => t.RecipientId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Packages", "SenderId", "dbo.People");
            DropForeignKey("dbo.Packages", "RecipientId", "dbo.People");
            DropIndex("dbo.Packages", new[] { "RecipientId" });
            DropIndex("dbo.Packages", new[] { "SenderId" });
            DropTable("dbo.People");
            DropTable("dbo.Packages");
        }
    }
}
