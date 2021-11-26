namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Department_Id", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "Department_Id");
            AddForeignKey("dbo.AspNetUsers", "Department_Id", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "Department_Id", "dbo.Departments");
            DropIndex("dbo.AspNetUsers", new[] { "Department_Id" });
            DropColumn("dbo.AspNetUsers", "Department_Id");
        }
    }
}
