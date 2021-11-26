using Business.IServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using DataAccess.IRepositories;
using DataAccess.Repositories;

namespace Business.Services
{
    public class FileService : ServiceBase<Entities.Models.File>, IFileService
    {
        private readonly IFileRepository repo;

        public FileService(IFileRepository repo)
            : base((RepositoryBase<Entities.Models.File>)repo)
        {
            this.repo = repo;            
        }
      
        public void UploadFilePDF()
        {
            string fileName = null;
            var httpRequest = HttpContext.Current.Request;
            var postedFile = httpRequest.Files["PDF"];
            fileName = new String(Path.GetFileNameWithoutExtension(postedFile.FileName).Take(10).ToArray()).Replace(" ", "-");
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(postedFile.FileName);
            var filePath = HttpContext.Current.Server.MapPath("~/PDF/" + fileName);
            postedFile.SaveAs(filePath);

            Entities.Models.File file = new Entities.Models.File()
                {

                    FileName = fileName,

                };
            this.repo.Add(file);
              
        }
        public byte[] GetPdfFile(int id)
        {
            Entities.Models.File file = repo.GetById(id);
            if (file == null)
            {
                return null;
            }
            var context = HttpContext.Current;
            string filePath = context.Server.MapPath("~/Image/" + file.FileName);
            context.Response.ContentType = "application/pdf";
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                using (var memoryStream = new MemoryStream())
                {
                    fileStream.CopyTo(memoryStream);
                    byte[] bytePdf = memoryStream.ToArray();
                    return bytePdf;
                }
            }
        }
        public void UploadFile()
        {

            string fileName = null;
            var httpRequest = HttpContext.Current.Request;
            var postedFile = httpRequest.Files["Image"];
            fileName = new String(Path.GetFileNameWithoutExtension(postedFile.FileName).Take(25).ToArray()).Replace(" ", "-");
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(postedFile.FileName);
            var filePath = HttpContext.Current.Server.MapPath("~/Image/" + fileName);

            postedFile.SaveAs(filePath);

            //int idFile = 0;
            Entities.Models.File file = new Entities.Models.File()
            {

                FileName = fileName,
                FileTitle = httpRequest["FileTitle"],
                FileDescription = httpRequest["FileDescription"],
                FileDuration = httpRequest["FileDuration"]

            };
            repo.Add(file);           
        }
       
        public IEnumerable<string> GetVideoFileName(int FileId) 
        {
            return repo.GetAll().Where(x => x.Id == FileId).Select(x => x.FileName);
        }
    }
}
