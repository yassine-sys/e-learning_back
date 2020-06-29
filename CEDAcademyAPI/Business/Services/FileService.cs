using Business.IServices;
using DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Entities.Models;
using DataAccess.IRepositories;

namespace Business.Services
{
    public class FileService : IFileService
    {
        private IFileRepository repo;

        public FileService(IFileRepository repo)
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
                db.Files.Add(file);
                db.SaveChanges();
                      
        }
        public byte[] GetPdfFile(int id)
        {
            Entities.Models.File file = db.Files.Find(id);
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


            int idFile = 0;
            Entities.Models.File file = new Entities.Models.File()
            {

             FileName = fileName,
             FileTitle = httpRequest["FileTitle"],
             FileDescription = httpRequest["FileDescription"],
             FileDuration = httpRequest["FileDuration"]

            };
                db.Files.Add(file);
                db.SaveChanges();
                idFile = file.Id;            
        }



    }
}
