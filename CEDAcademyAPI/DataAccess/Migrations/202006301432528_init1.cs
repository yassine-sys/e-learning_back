namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(),
                        IsAnswer = c.String(),
                        ExamID = c.Int(nullable: false),
                        QuesID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.ExamID, cascadeDelete: true)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.ExamID)
                .Index(t => t.Question_Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CourseID = c.Int(nullable: false),
                        userId = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        score = c.Int(nullable: false),
                        ExamID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.ExamID, cascadeDelete: true)
                .Index(t => t.ExamID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        Description = c.String(),
                        OverViewVideo = c.String(),
                        DepartmentID = c.Int(nullable: false),
                        UserId = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        Description = c.String(),
                        CourseID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        Description = c.String(),
                        ChapterID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chapters", t => t.ChapterID, cascadeDelete: true)
                .Index(t => t.ChapterID);
            
            CreateTable(
                "dbo.Paragraphs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        Description = c.String(),
                        SectionID = c.Int(nullable: false),
                        Video = c.String(),
                        Pdf = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .Index(t => t.SectionID);
            
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(nullable: false),
                        FileDuration = c.String(),
                        FileTitle = c.String(),
                        FileDescription = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                        FileType_TypeId = c.Int(),
                        Paragraph_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FileTypes", t => t.FileType_TypeId)
                .ForeignKey("dbo.Paragraphs", t => t.Paragraph_Id)
                .Index(t => t.FileType_TypeId)
                .Index(t => t.Paragraph_Id);
            
            CreateTable(
                "dbo.FileTypes",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TypeId);
            
            CreateTable(
                "dbo.FileProgresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pourcentage = c.Single(nullable: false),
                        CurrentTime = c.Single(nullable: false),
                        FileId = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Files", t => t.FileId, cascadeDelete: true)
                .Index(t => t.FileId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Score = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.ExamResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Score = c.Int(nullable: false),
                        TimeSpent = c.String(),
                        ExamID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Exams", t => t.ExamID, cascadeDelete: true)
                .Index(t => t.ExamID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuesText = c.String(nullable: false),
                        types = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OptionText = c.String(),
                        values = c.Boolean(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                        QuesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Quizs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CourseID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.QuizResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Score = c.Int(nullable: false),
                        QuizID = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Quizs", t => t.QuizID, cascadeDelete: true)
                .Index(t => t.QuizID);
            
            CreateTable(
                "dbo.BusinessUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        BusinessUnitId = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusinessUnits", t => t.BusinessUnitId, cascadeDelete: true)
                .Index(t => t.BusinessUnitId);
            
            CreateTable(
                "dbo.ParagraphProgresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParagraphID = c.Int(nullable: false),
                        SectionID = c.Int(nullable: false),
                        ChapterID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        userId = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseID = c.String(),
                        CourseProgress = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.String(),
                        LastModifiedDate = c.DateTime(nullable: false),
                        IsActif = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.QuestionExams",
                c => new
                    {
                        Question_Id = c.Int(nullable: false),
                        Exam_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Question_Id, t.Exam_Id })
                .ForeignKey("dbo.Questions", t => t.Question_Id, cascadeDelete: true)
                .ForeignKey("dbo.Exams", t => t.Exam_Id, cascadeDelete: true)
                .Index(t => t.Question_Id)
                .Index(t => t.Exam_Id);
            
            CreateTable(
                "dbo.OptionQuestions",
                c => new
                    {
                        Option_Id = c.Int(nullable: false),
                        Question_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Option_Id, t.Question_Id })
                .ForeignKey("dbo.Options", t => t.Option_Id, cascadeDelete: true)
                .ForeignKey("dbo.Questions", t => t.Question_Id, cascadeDelete: true)
                .Index(t => t.Option_Id)
                .Index(t => t.Question_Id);
            
            CreateTable(
                "dbo.QuizQuestions",
                c => new
                    {
                        Quiz_Id = c.Int(nullable: false),
                        Question_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Quiz_Id, t.Question_Id })
                .ForeignKey("dbo.Quizs", t => t.Quiz_Id, cascadeDelete: true)
                .ForeignKey("dbo.Questions", t => t.Question_Id, cascadeDelete: true)
                .Index(t => t.Quiz_Id)
                .Index(t => t.Question_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Departments", "BusinessUnitId", "dbo.BusinessUnits");
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.Answers", "ExamID", "dbo.Exams");
            DropForeignKey("dbo.QuizResults", "QuizID", "dbo.Quizs");
            DropForeignKey("dbo.QuizQuestions", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.QuizQuestions", "Quiz_Id", "dbo.Quizs");
            DropForeignKey("dbo.Quizs", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.OptionQuestions", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.OptionQuestions", "Option_Id", "dbo.Options");
            DropForeignKey("dbo.QuestionExams", "Exam_Id", "dbo.Exams");
            DropForeignKey("dbo.QuestionExams", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.ExamResults", "ExamID", "dbo.Exams");
            DropForeignKey("dbo.Exams", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Ratings", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Paragraphs", "SectionID", "dbo.Sections");
            DropForeignKey("dbo.FileProgresses", "FileId", "dbo.Files");
            DropForeignKey("dbo.Files", "Paragraph_Id", "dbo.Paragraphs");
            DropForeignKey("dbo.Files", "FileType_TypeId", "dbo.FileTypes");
            DropForeignKey("dbo.Sections", "ChapterID", "dbo.Chapters");
            DropForeignKey("dbo.Chapters", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Certificates", "ExamID", "dbo.Exams");
            DropIndex("dbo.QuizQuestions", new[] { "Question_Id" });
            DropIndex("dbo.QuizQuestions", new[] { "Quiz_Id" });
            DropIndex("dbo.OptionQuestions", new[] { "Question_Id" });
            DropIndex("dbo.OptionQuestions", new[] { "Option_Id" });
            DropIndex("dbo.QuestionExams", new[] { "Exam_Id" });
            DropIndex("dbo.QuestionExams", new[] { "Question_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Departments", new[] { "BusinessUnitId" });
            DropIndex("dbo.QuizResults", new[] { "QuizID" });
            DropIndex("dbo.Quizs", new[] { "CourseID" });
            DropIndex("dbo.ExamResults", new[] { "ExamID" });
            DropIndex("dbo.Ratings", new[] { "CourseID" });
            DropIndex("dbo.FileProgresses", new[] { "FileId" });
            DropIndex("dbo.Files", new[] { "Paragraph_Id" });
            DropIndex("dbo.Files", new[] { "FileType_TypeId" });
            DropIndex("dbo.Paragraphs", new[] { "SectionID" });
            DropIndex("dbo.Sections", new[] { "ChapterID" });
            DropIndex("dbo.Chapters", new[] { "CourseID" });
            DropIndex("dbo.Courses", new[] { "DepartmentID" });
            DropIndex("dbo.Certificates", new[] { "ExamID" });
            DropIndex("dbo.Exams", new[] { "CourseID" });
            DropIndex("dbo.Answers", new[] { "Question_Id" });
            DropIndex("dbo.Answers", new[] { "ExamID" });
            DropTable("dbo.QuizQuestions");
            DropTable("dbo.OptionQuestions");
            DropTable("dbo.QuestionExams");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Subscriptions");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.ParagraphProgresses");
            DropTable("dbo.Departments");
            DropTable("dbo.BusinessUnits");
            DropTable("dbo.QuizResults");
            DropTable("dbo.Quizs");
            DropTable("dbo.Options");
            DropTable("dbo.Questions");
            DropTable("dbo.ExamResults");
            DropTable("dbo.Ratings");
            DropTable("dbo.FileProgresses");
            DropTable("dbo.FileTypes");
            DropTable("dbo.Files");
            DropTable("dbo.Paragraphs");
            DropTable("dbo.Sections");
            DropTable("dbo.Chapters");
            DropTable("dbo.Courses");
            DropTable("dbo.Certificates");
            DropTable("dbo.Exams");
            DropTable("dbo.Answers");
        }
    }
}
