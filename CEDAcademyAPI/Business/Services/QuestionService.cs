using Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    class QuestionService<Option> : IQuestionService<Option> where Option:class
    {
        private ApplicationContext context;
        public QuestionService(ApplicationContext context)
        {
            this.context = context;
        }
        public IEnumerable<Option> GetOptionByQuestionID(int QuesID)
        {
            return context.Questions.Where(x => x.Option.Questions.Any(c => c.QuesID == QuesID));
        }
    }
}
