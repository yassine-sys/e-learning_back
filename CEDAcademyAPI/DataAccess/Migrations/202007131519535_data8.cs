namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OptionQuestions", "Option_Id", "dbo.Options");
            DropForeignKey("dbo.OptionQuestions", "Question_Id", "dbo.Questions");
            DropIndex("dbo.OptionQuestions", new[] { "Option_Id" });
            DropIndex("dbo.OptionQuestions", new[] { "Question_Id" });
            AddColumn("dbo.Options", "Questions_Id", c => c.Int());
            CreateIndex("dbo.Options", "Questions_Id");
            AddForeignKey("dbo.Options", "Questions_Id", "dbo.Questions", "Id");
            DropTable("dbo.OptionQuestions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OptionQuestions",
                c => new
                    {
                        Option_Id = c.Int(nullable: false),
                        Question_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Option_Id, t.Question_Id });
            
            DropForeignKey("dbo.Options", "Questions_Id", "dbo.Questions");
            DropIndex("dbo.Options", new[] { "Questions_Id" });
            DropColumn("dbo.Options", "Questions_Id");
            CreateIndex("dbo.OptionQuestions", "Question_Id");
            CreateIndex("dbo.OptionQuestions", "Option_Id");
            AddForeignKey("dbo.OptionQuestions", "Question_Id", "dbo.Questions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.OptionQuestions", "Option_Id", "dbo.Options", "Id", cascadeDelete: true);
        }
    }
}
