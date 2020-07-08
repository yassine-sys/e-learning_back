namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class var : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Answers", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Answers", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Answers", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Exams", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Exams", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Exams", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Certificates", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Certificates", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Certificates", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Courses", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Courses", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Courses", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Chapters", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Chapters", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Chapters", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Sections", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Sections", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Sections", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Paragraphs", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Paragraphs", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Paragraphs", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Files", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Files", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Files", "IsActif", c => c.Boolean());
            AlterColumn("dbo.FileProgresses", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.FileProgresses", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.FileProgresses", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Ratings", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Ratings", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Ratings", "IsActif", c => c.Boolean());
            AlterColumn("dbo.ExamResults", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.ExamResults", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.ExamResults", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Questions", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Questions", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Questions", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Options", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Options", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Options", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Quizs", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Quizs", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Quizs", "IsActif", c => c.Boolean());
            AlterColumn("dbo.QuizResults", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.QuizResults", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.QuizResults", "IsActif", c => c.Boolean());
            AlterColumn("dbo.BusinessUnits", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.BusinessUnits", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.BusinessUnits", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Departments", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Departments", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Departments", "IsActif", c => c.Boolean());
            AlterColumn("dbo.ParagraphProgresses", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.ParagraphProgresses", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.ParagraphProgresses", "IsActif", c => c.Boolean());
            AlterColumn("dbo.Subscriptions", "CreatedDate", c => c.DateTime());
            AlterColumn("dbo.Subscriptions", "LastModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Subscriptions", "IsActif", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Subscriptions", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Subscriptions", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Subscriptions", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ParagraphProgresses", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ParagraphProgresses", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ParagraphProgresses", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Departments", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Departments", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Departments", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BusinessUnits", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.BusinessUnits", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BusinessUnits", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.QuizResults", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.QuizResults", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.QuizResults", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Quizs", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Quizs", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Quizs", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Options", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Options", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Options", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Questions", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Questions", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Questions", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ExamResults", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ExamResults", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ExamResults", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Ratings", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Ratings", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Ratings", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.FileProgresses", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.FileProgresses", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.FileProgresses", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Files", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Files", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Files", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Paragraphs", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Paragraphs", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Paragraphs", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sections", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Sections", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sections", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Chapters", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Chapters", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Chapters", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Courses", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Courses", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Courses", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Certificates", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Certificates", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Certificates", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Exams", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Exams", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Exams", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Answers", "IsActif", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Answers", "LastModifiedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Answers", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
