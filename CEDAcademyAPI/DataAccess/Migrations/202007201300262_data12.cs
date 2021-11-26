namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Course_Id", c => c.Int());
            CreateIndex("dbo.Courses", "Course_Id");
            AddForeignKey("dbo.Courses", "Course_Id", "dbo.Courses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Courses", new[] { "Course_Id" });
            DropColumn("dbo.Courses", "Course_Id");
        }
    }
}
