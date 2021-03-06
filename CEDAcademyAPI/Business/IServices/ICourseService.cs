using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IServices
{
    public interface ICourseService : IServiceBase<Course>
    {
        int GetCoursesCount();
        void UploadFile();
        byte[] GetImage(int id);

    }
}
