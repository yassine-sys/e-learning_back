namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "BusinessUnit_Id", "dbo.BusinessUnits");
            DropIndex("dbo.Departments", new[] { "BusinessUnit_Id" });
            RenameColumn(table: "dbo.Departments", name: "BusinessUnit_Id", newName: "BusinessUnitId");
            AlterColumn("dbo.Departments", "BusinessUnitId", c => c.Int(nullable: false));
            CreateIndex("dbo.Departments", "BusinessUnitId");
            AddForeignKey("dbo.Departments", "BusinessUnitId", "dbo.BusinessUnits", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "BusinessUnitId", "dbo.BusinessUnits");
            DropIndex("dbo.Departments", new[] { "BusinessUnitId" });
            AlterColumn("dbo.Departments", "BusinessUnitId", c => c.Int());
            RenameColumn(table: "dbo.Departments", name: "BusinessUnitId", newName: "BusinessUnit_Id");
            CreateIndex("dbo.Departments", "BusinessUnit_Id");
            AddForeignKey("dbo.Departments", "BusinessUnit_Id", "dbo.BusinessUnits", "Id");
        }
    }
}
