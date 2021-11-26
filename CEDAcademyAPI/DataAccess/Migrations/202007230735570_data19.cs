namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data19 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.QuestionExams", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.QuestionExams", "Exam_Id", "dbo.Exams");
            DropIndex("dbo.QuestionExams", new[] { "Question_Id" });
            DropIndex("dbo.QuestionExams", new[] { "Exam_Id" });
            AddColumn("dbo.Questions", "ExamID", c => c.Int());
            CreateIndex("dbo.Questions", "ExamID");
            AddForeignKey("dbo.Questions", "ExamID", "dbo.Exams", "Id");
            DropTable("dbo.QuestionExams");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.QuestionExams",
                c => new
                    {
                        Question_Id = c.Int(nullable: false),
                        Exam_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Question_Id, t.Exam_Id });
            
            DropForeignKey("dbo.Questions", "ExamID", "dbo.Exams");
            DropIndex("dbo.Questions", new[] { "ExamID" });
            DropColumn("dbo.Questions", "ExamID");
            CreateIndex("dbo.QuestionExams", "Exam_Id");
            CreateIndex("dbo.QuestionExams", "Question_Id");
            AddForeignKey("dbo.QuestionExams", "Exam_Id", "dbo.Exams", "Id", cascadeDelete: true);
            AddForeignKey("dbo.QuestionExams", "Question_Id", "dbo.Questions", "Id", cascadeDelete: true);
        }
    }
}
