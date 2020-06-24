using Business.IServices;
using Business.Services;
using CEDAcademyAPI.Models;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;

namespace NinjectWebCommon {
    /// <summary>
    /// Resolves Dependencies Using Ninject
    /// </summary>
    public class NinjectHttpResolver : IDependencyResolver, IDependencyScope
    {
        public IKernel Kernel { get; private set; }
        public NinjectHttpResolver(params NinjectModule[] modules)
        {
            Kernel = new StandardKernel(modules);
        }

        public NinjectHttpResolver(Assembly assembly)
        {
            Kernel = new StandardKernel();
            Kernel.Load(assembly);
        }

        public object GetService(Type serviceType)
        {
            return Kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Kernel.GetAll(serviceType);
        }

        public void Dispose()
        {
            //Do Nothing
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }
    }


    // List and Describe Necessary HttpModules
    // This class is optional if you already Have NinjectMvc
    public class NinjectHttpModules
    {
        //Return Lists of Modules in the Application
        public static NinjectModule[] Modules
        {
            get
            {
                return new[] { new MainModule() };
            }
        }

        //Main Module For Application
        public class MainModule : NinjectModule
        {
            public override void Load()
            {
                //TODO: Bind to Concrete Types Here
                 Bind<IDepartmentService>().To<DepartmentService>().InRequestScope();
                 Bind<IAnswerService>().To<AnswerService>().InRequestScope();
                 Bind<IBusinessUnitService>().To<BusinessUnitService>().InRequestScope();
                 Bind<ICertificateService>().To<CertificateService>().InRequestScope();
                 Bind<IChapterService>().To<ChapterService>().InRequestScope();
                 Bind<ICourseService>().To<CourseService>().InRequestScope();
                 Bind<IExamService>().To<ExamService>().InRequestScope();
                 Bind<IExamResultService>().To<ExamResultService>().InRequestScope();
                 Bind<IFileProgressService>().To<FileProgressService>().InRequestScope();
                 Bind<IFileService>().To<FileService>().InRequestScope();
                 Bind<IOptionService>().To<OptionService>().InRequestScope();
                 Bind<IParagraphProgressService>().To<ParagraphProgressService>().InRequestScope();
                 Bind<IParagraphService>().To<ParagraphService>().InRequestScope();
                 Bind<IQuestionService>().To<QuestionService>().InRequestScope();
                 Bind<IQuizService>().To<QuizService>().InRequestScope();
                 Bind<IQuizResultService>().To<IQuizResultService>().InRequestScope();
                 Bind<IRatingService>().To<RatingService>().InRequestScope();
                 Bind<ISectionService>().To<SectionService>().InRequestScope();
                 Bind<ISubscriptionService>().To<SubscriptionService>().InRequestScope();
                 Bind<ApplicationDbContext>().To<ApplicationDbContext>().InRequestScope();
                //Bind<Iclasse>.to<Classe>();
            }
        }
    }


    /// <summary>
    /// Its job is to Register Ninject Modules and Resolve Dependencies
    /// </summary>
    public class NinjectHttpContainer
    {
        private static NinjectHttpResolver _resolver;

        //Register Ninject Modules
        public static void RegisterModules(NinjectModule[] modules)
        {
            _resolver = new NinjectHttpResolver(modules);
            GlobalConfiguration.Configuration.DependencyResolver = _resolver;
        }

        public static void RegisterAssembly()
        {
            _resolver = new NinjectHttpResolver(Assembly.GetExecutingAssembly());
            //This is where the actual hookup to the Web API Pipeline is done.
            GlobalConfiguration.Configuration.DependencyResolver = _resolver;
        }

        //Manually Resolve Dependencies
        public static T Resolve<T>()
        {
            return _resolver.Kernel.Get<T>();
        }
    }
}
