namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "Department_Id" });
            RenameColumn(table: "dbo.Courses", name: "Department_Id", newName: "DepartmentID");
            AlterColumn("dbo.Courses", "DepartmentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "DepartmentID");
            AddForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "DepartmentID" });
            AlterColumn("dbo.Courses", "DepartmentID", c => c.Int());
            RenameColumn(table: "dbo.Courses", name: "DepartmentID", newName: "Department_Id");
            CreateIndex("dbo.Courses", "Department_Id");
            AddForeignKey("dbo.Courses", "Department_Id", "dbo.Departments", "Id");
        }
    }
}
