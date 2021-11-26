using Business.IServices;
using DataAccess.Infrastructure;
using DataAccess.IRepositories;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Business.Services
{
    public class CourseService : ServiceBase<Course>, ICourseService
    {

        private readonly ICourseRepository CourseRepository;
        public CourseService(ICourseRepository CourseRepository)
            : base((RepositoryBase<Course>)CourseRepository)
        {
            this.CourseRepository = CourseRepository;
        }
       public int GetCoursesCount()
        {
            return CourseRepository.GetAll().Count();
        }

        public void UploadFile()
        {
            string fileName = null;
            var httpRequest = HttpContext.Current.Request;
            var postedFile = httpRequest.Files["OverViewVideo"];
            fileName = new String(Path.GetFileNameWithoutExtension(postedFile.FileName).Take(10).ToArray()).Replace(" ", "-");
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(postedFile.FileName);
            var filePath = HttpContext.Current.Server.MapPath("~/Image/" + fileName);
            postedFile.SaveAs(filePath);
            //course.OverViewVideo = filePath;
            System.Diagnostics.Debug.WriteLine(filePath);



            Course course = new Course()
            {
                title = httpRequest["title"],
                Description = httpRequest["Description"],
                OverViewVideo = fileName,
                DepartmentID = int.Parse(httpRequest["DepartmentID"])



            };
            CourseRepository.Add(course);



        }
        public byte[] GetImage(int id)
        {
            Course course = CourseRepository.GetById(id);
            if (course == null)
            {
                return null;
            }
            var context = HttpContext.Current;
            string filePath = context.Server.MapPath("~/Image/" + course.OverViewVideo);
            context.Response.ContentType = "image/png";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (var memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    Bitmap image = new Bitmap(1, 1);
                    image.Save(memoryStream, ImageFormat.Png);
                    byte[] byteImage = memoryStream.ToArray();
                    return byteImage;
                }
            }
        }
    }
}
