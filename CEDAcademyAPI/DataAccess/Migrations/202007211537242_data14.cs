namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data14 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Questions", name: "Quizzes_Id", newName: "QuizID");
            RenameIndex(table: "dbo.Questions", name: "IX_Quizzes_Id", newName: "IX_QuizID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Questions", name: "IX_QuizID", newName: "IX_Quizzes_Id");
            RenameColumn(table: "dbo.Questions", name: "QuizID", newName: "Quizzes_Id");
        }
    }
}
