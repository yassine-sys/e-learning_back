using AutoMapper;
using Business.IServices;
using Entities.Models;
using Entities.ModelsDTO;
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
        private readonly IFileService service;
        private readonly IMapper mapper;

        public FileController(IFileService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
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
        public IEnumerable<FileDTO> GetFiles()
        {
            var f = service.GetAll();
            return mapper.Map<IEnumerable<FileDTO>>(f);
        }
        [HttpGet]
        [Route("{id}")]
        public FileDTO GetFileById(int id)
        {
            var file = service.GetById(id);
            return mapper.Map<FileDTO>(file);
        }
    }
}
