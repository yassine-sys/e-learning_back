namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "BusinessUnitId", "dbo.BusinessUnits");
            DropIndex("dbo.Departments", new[] { "BusinessUnitId" });
            RenameColumn(table: "dbo.Departments", name: "BusinessUnitId", newName: "BusinessUnit_Id");
            AlterColumn("dbo.Departments", "BusinessUnit_Id", c => c.Int());
            CreateIndex("dbo.Departments", "BusinessUnit_Id");
            AddForeignKey("dbo.Departments", "BusinessUnit_Id", "dbo.BusinessUnits", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "BusinessUnit_Id", "dbo.BusinessUnits");
            DropIndex("dbo.Departments", new[] { "BusinessUnit_Id" });
            AlterColumn("dbo.Departments", "BusinessUnit_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Departments", name: "BusinessUnit_Id", newName: "BusinessUnitId");
            CreateIndex("dbo.Departments", "BusinessUnitId");
            AddForeignKey("dbo.Departments", "BusinessUnitId", "dbo.BusinessUnits", "Id", cascadeDelete: true);
        }
    }
}
