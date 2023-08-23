namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoticeTypeEntitiesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        TId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Types", t => t.TId, cascadeDelete: true)
                .Index(t => t.TId);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notices", "TId", "dbo.Types");
            DropIndex("dbo.Notices", new[] { "TId" });
            DropTable("dbo.Types");
            DropTable("dbo.Notices");
        }
    }
}
