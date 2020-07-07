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
    [RoutePrefix("api/File")]
    public class FileController : ApiController
    {
        private IFileService service;

        public FileController(IFileService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("UploadFile")]
        public HttpResponseMessage UploadFile()
        {
            this.service.UploadFile();
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpGet]
        [Route("PdfFile/{id}")]
        public byte[] GetPdfFile(int id)
        {
            return this.service.GetPdfFile(id);
        }
        [HttpGet]
        [Route("VideoFile/{id}")]
        public IEnumerable<string> GetVideoFileName(int id)
        {
            return service.GetVideoFileName(id);
        }
        [HttpGet]
        public IEnumerable<File> GetFiles()
        {
            return this.service.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public File GetFileById(int id)
        {
            return this.service.GetById(id);
        }
    }
}
