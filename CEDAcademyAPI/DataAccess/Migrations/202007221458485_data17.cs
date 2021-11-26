namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data17 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Options", "Questions_Id", "dbo.Questions");
            DropIndex("dbo.Options", new[] { "Questions_Id" });
            RenameColumn(table: "dbo.Options", name: "Questions_Id", newName: "QuestionID");
            AlterColumn("dbo.Options", "QuestionID", c => c.Int(nullable: false));
            CreateIndex("dbo.Options", "QuestionID");
            AddForeignKey("dbo.Options", "QuestionID", "dbo.Questions", "Id", cascadeDelete: true);
            DropColumn("dbo.Options", "QuesID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Options", "QuesID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Options", "QuestionID", "dbo.Questions");
            DropIndex("dbo.Options", new[] { "QuestionID" });
            AlterColumn("dbo.Options", "QuestionID", c => c.Int());
            RenameColumn(table: "dbo.Options", name: "QuestionID", newName: "Questions_Id");
            CreateIndex("dbo.Options", "Questions_Id");
            AddForeignKey("dbo.Options", "Questions_Id", "dbo.Questions", "Id");
        }
    }
}
