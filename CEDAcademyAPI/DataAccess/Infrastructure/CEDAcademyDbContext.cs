using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Infrastructure
{
   
    public class CEDAcademyDbContext : IdentityDbContext<ApplicationUser>
    {
        public CEDAcademyDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static CEDAcademyDbContext Create()
        {
            return new CEDAcademyDbContext();
        }


        public System.Data.Entity.DbSet<Entities.Models.Course> Courses { get; set; }
        public System.Data.Entity.DbSet<Entities.Models.Chapter> Chapters { get; set; }

        public System.Data.Entity.DbSet<Entities.Models.Section> Sections { get; set; }

        public System.Data.Entity.DbSet<Entities.Models.Paragraph> Paragraphs { get; set; }

        public System.Data.Entity.DbSet<Entities.Models.File> Files { get; set; }

        public System.Data.Entity.DbSet<Entities.Models.FileProgress> FileProgresses { get; set; }

        public System.Data.Entity.DbSet<Entities.Models.Subscription> Subscriptions { get; set; }

        public System.Data.Entity.DbSet<Entities.Models.ParagraphProgress> ParagraphProgresses { get; set; }

        public System.Data.Entity.DbSet<Entities.Models.Rating> Ratings { get; set; }
        public System.Data.Entity.DbSet<Entities.Models.Answer> Answers { get; set; }
        public System.Data.Entity.DbSet<Entities.Models.BusinessUnit> BusinessUnits { get; set; }
        public System.Data.Entity.DbSet<Entities.Models.Certificate> Certificates { get; set; }
        public System.Data.Entity.DbSet<Entities.Models.Department> Departments { get; set; }
        public System.Data.Entity.DbSet<Entities.Models.Exam> Exams { get; set; }
        public System.Data.Entity.DbSet<Entities.Models.ExamResult> ExamResults { get; set; }
        public System.Data.Entity.DbSet<Entities.Models.Option> Options { get; set; }
        public System.Data.Entity.DbSet<Entities.Models.Question> Questions { get; set; }
        public System.Data.Entity.DbSet<Entities.Models.Quiz> Quizzes { get; set; }
        public System.Data.Entity.DbSet<Entities.Models.QuizResult> QuizResults { get; set; }

    
}
}
