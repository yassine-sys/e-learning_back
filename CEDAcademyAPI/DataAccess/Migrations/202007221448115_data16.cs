namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data16 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Options", name: "Questions_Id", newName: "QuesID");
            RenameIndex(table: "dbo.Options", name: "IX_Questions_Id", newName: "IX_QuesID");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Options", name: "QuesID", newName: "Questions_Id");
            RenameIndex(table: "dbo.Options", name: "IX_QuesID", newName: "IX_Questions_Id");
        }
    }
}
