[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CEDAcademyAPI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(CEDAcademyAPI.App_Start.NinjectWebCommon), "Stop")]

namespace CEDAcademyAPI.App_Start
{
    using System;
    using System.Web;
    using System.Web.Http;
    using Business.IServices;
    using Business.Services;
    using CEDAcademyAPI.Models;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;
    using Ninject.Web.WebApi;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IDepartmentService>().To<DepartmentService>().InRequestScope();
            kernel.Bind<IAnswerService>().To<AnswerService>().InRequestScope();
            kernel.Bind<IBusinessUnitService>().To<BusinessUnitService>().InRequestScope();
            kernel.Bind<ICertificateService>().To<CertificateService>().InRequestScope();
            kernel.Bind<IChapterService>().To<ChapterService>().InRequestScope();
            kernel.Bind<ICourseService>().To<CourseService>().InRequestScope();
            kernel.Bind<IExamService>().To<ExamService>().InRequestScope();
            kernel.Bind<IExamResultService>().To<ExamResultService>().InRequestScope();
            kernel.Bind<IFileProgressService>().To<FileProgressService>().InRequestScope();
            kernel.Bind<IFileService>().To<FileService>().InRequestScope();
            kernel.Bind<IOptionService>().To<OptionService>().InRequestScope();
            kernel.Bind<IParagraphProgressService>().To<ParagraphProgressService>().InRequestScope();
            kernel.Bind<IParagraphService>().To<ParagraphService>().InRequestScope();
            kernel.Bind<IQuestionService>().To<QuestionService>().InRequestScope();
            kernel.Bind<IQuizService>().To<QuizService>().InRequestScope();
            kernel.Bind<IQuizResultService>().To<IQuizResultService>().InRequestScope();
            kernel.Bind<IRatingService>().To<RatingService>().InRequestScope();
            kernel.Bind<ISectionService>().To<SectionService>().InRequestScope();
            kernel.Bind<ISubscriptionService>().To<SubscriptionService>().InRequestScope();
            kernel.Bind<CEDAcacademyDbContext>().To<CEDAcacademyDbContext>().InRequestScope();
        }
    }
}