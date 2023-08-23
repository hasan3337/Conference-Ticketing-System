namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypeRemovedCategoryCreated2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Types", newName: "Categories");
            RenameColumn(table: "dbo.Notices", name: "TId", newName: "CId");
            RenameIndex(table: "dbo.Notices", name: "IX_TId", newName: "IX_CId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Notices", name: "IX_CId", newName: "IX_TId");
            RenameColumn(table: "dbo.Notices", name: "CId", newName: "TId");
            RenameTable(name: "dbo.Categories", newName: "Types");
        }
    }
}
