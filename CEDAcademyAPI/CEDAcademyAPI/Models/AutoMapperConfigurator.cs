using Entities.Models;
using Entities.ModelsDTO;

namespace CEDAcademyAPI.Models
{
    public static class AutoMapperConfigurator
    {
        internal static void CreateMaps(AutoMapper.IMapperConfigurationExpression config)
        {
            config.CreateMap<BusinessUnit, BusinessUnitDTO>().ReverseMap();
            config.CreateMap<Certificate, CertificateDTO>().ReverseMap();
            config.CreateMap<Chapter, ChapterDTO>().ReverseMap();
            config.CreateMap<Course, CourseDTO>().ReverseMap();
            config.CreateMap<Department, DepartmentDTO>().ReverseMap();
            config.CreateMap<Exam, ExamDTO>().ReverseMap();
            config.CreateMap<ExamResult, ExamResultDTO>().ReverseMap();
            config.CreateMap<File, FileDTO>().ReverseMap();
            config.CreateMap<FileProgress, FileProgressDTO>().ReverseMap();
            config.CreateMap<Option, OptionDTO>().ReverseMap();
            config.CreateMap<Paragraph, ParagraphDTO>().ReverseMap();
            config.CreateMap<ParagraphProgress, ParagraphProgressDTO>().ReverseMap();
            config.CreateMap<Question, QuestionDTO>().ReverseMap();
            config.CreateMap<Quiz, QuizDTO>().ReverseMap();
            config.CreateMap<QuizResult, QuizResultDTO>().ReverseMap();
            config.CreateMap<Rating, RatingDTO>().ReverseMap();
            config.CreateMap<Section, SectionDTO>().ReverseMap();
            config.CreateMap<Subscription, SubscriptionDTO>().ReverseMap();
        }
    }
}