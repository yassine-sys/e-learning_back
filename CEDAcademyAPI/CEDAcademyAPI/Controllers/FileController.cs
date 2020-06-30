using Business.IServices;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CEDAcademyAPI.Controllers
{
    public class FileController : ApiController
    {
        private IFileService service;

        public FileController(IFileService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("api/UploadFile")]
        public HttpResponseMessage UploadFile()
        {
            this.service.UploadFile();
            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpGet]
        [Route("api/PdfFile/{id}")]
        public byte[] GetPdfFile(int id)
        {
            return this.service.GetPdfFile(id);
        }
        [HttpGet]
        [Route("api/VideoFile/{id}")]
        public IEnumerable<string> GetVideoFileName(int id)
        {
            return service.GetVideoFileName(id);
        }
        [HttpGet]
        [Route("api/Files")]
        public IEnumerable<File> GetFiles()
        {
            return this.service.GetAllFiles();
        }
        [HttpGet]
        [Route("api/Files/{id}")]
        public File GetFileById(int id)
        {
            return this.service.GetFileById(id);
        }
    }
}
