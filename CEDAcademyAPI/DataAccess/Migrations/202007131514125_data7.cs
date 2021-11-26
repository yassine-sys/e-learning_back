namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.QuizQuestions", "Quiz_Id", "dbo.Quizs");
            DropForeignKey("dbo.QuizQuestions", "Question_Id", "dbo.Questions");
            DropIndex("dbo.QuizQuestions", new[] { "Quiz_Id" });
            DropIndex("dbo.QuizQuestions", new[] { "Question_Id" });
            AddColumn("dbo.Questions", "Quizzes_Id", c => c.Int());
            CreateIndex("dbo.Questions", "Quizzes_Id");
            AddForeignKey("dbo.Questions", "Quizzes_Id", "dbo.Quizs", "Id");
            DropTable("dbo.QuizQuestions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.QuizQuestions",
                c => new
                    {
                        Quiz_Id = c.Int(nullable: false),
                        Question_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Quiz_Id, t.Question_Id });
            
            DropForeignKey("dbo.Questions", "Quizzes_Id", "dbo.Quizs");
            DropIndex("dbo.Questions", new[] { "Quizzes_Id" });
            DropColumn("dbo.Questions", "Quizzes_Id");
            CreateIndex("dbo.QuizQuestions", "Question_Id");
            CreateIndex("dbo.QuizQuestions", "Quiz_Id");
            AddForeignKey("dbo.QuizQuestions", "Question_Id", "dbo.Questions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.QuizQuestions", "Quiz_Id", "dbo.Quizs", "Id", cascadeDelete: true);
        }
    }
}
