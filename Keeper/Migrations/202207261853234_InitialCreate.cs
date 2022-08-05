namespace Keeper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrates",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Name = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Role = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Attends",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        memberid = c.String(),
                        eventid = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.String(),
                        Mode = c.String(),
                        Purpose = c.String(),
                        Dated = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Jobid = c.Int(nullable: false),
                        Name = c.String(),
                        DOB = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Category = c.String(),
                        Serialno = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Eventcals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Dates = c.String(),
                        Price = c.Int(nullable: false),
                        Venue = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Families",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FamilyID = c.Int(nullable: false),
                        Reference = c.String(),
                        Refecence2 = c.String(),
                        Refecence3 = c.String(),
                        Refecence4 = c.String(),
                        Refecence5 = c.String(),
                        Refecence6 = c.String(),
                        Refecence7 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GroupMembers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        personid = c.Int(nullable: false),
                        groupid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Messangers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Message = c.String(),
                        Createdon = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Ministerds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Name = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Rep = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DOB = c.String(),
                        Gender = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Status = c.String(),
                        Minister = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Occupation = c.String(),
                        FamilyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Category = c.String(),
                        Supervisor = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        level = c.String(),
                        logins = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Projects");
            DropTable("dbo.People");
            DropTable("dbo.Ministerds");
            DropTable("dbo.Messangers");
            DropTable("dbo.Jobs");
            DropTable("dbo.Groups");
            DropTable("dbo.GroupMembers");
            DropTable("dbo.Families");
            DropTable("dbo.Eventcals");
            DropTable("dbo.Equipments");
            DropTable("dbo.Employees");
            DropTable("dbo.Donations");
            DropTable("dbo.Attends");
            DropTable("dbo.Administrates");
        }
    }
}
