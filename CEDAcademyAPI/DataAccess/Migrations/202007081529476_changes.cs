namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "DepartmentID" });
            RenameColumn(table: "dbo.Courses", name: "DepartmentID", newName: "Department_Id");
            AlterColumn("dbo.Courses", "Department_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Department_Id");
            AddForeignKey("dbo.Courses", "Department_Id", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "Department_Id" });
            AlterColumn("dbo.Courses", "Department_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Courses", name: "Department_Id", newName: "DepartmentID");
            CreateIndex("dbo.Courses", "DepartmentID");
            AddForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
