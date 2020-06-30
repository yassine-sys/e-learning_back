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
    public class FileProgressController : ApiController
    {
        private IFileProgressService service;

        public FileProgressController(IFileProgressService service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("api/Progress/{id}")]
        public HttpResponseMessage AddFileProgress(FileProgress FileProgress)
        {
            service.AddFileProgress(FileProgress);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpGet]
        [Route("api/ProgressByUserId/{id}")]
        public IHttpActionResult GetFileProgressByUserId(string UserId)
        {
            var FileProgress = service.GetFileProgressByUserId(UserId);
            return Ok(FileProgress);
        }

        [HttpPut]
        [Route("api/PutProgress")]
        public IHttpActionResult UpdateFileProgress(FileProgress fp)
        {
            service.UpdateFileProgress(fp);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpGet]
        [Route("api/GetProgress/{id}")]
        public FileProgress GetFileProgressById(int FileProgressId)
        {
            return service.GetFileProgressById(FileProgressId);
        }
        [HttpGet]
        [Route("api/FileTrack")]
        public IEnumerable<FileProgress> GetFileProgresses()
        {
            return service.GetFileProgresses();
        }
        [HttpGet]
        [Route("api/UserPerVideo")]
        public IHttpActionResult GetFilesViewsCount()
        {
            return Ok(service.GetFilesViewsCount());
        }

        [HttpGet]
        [Route("api/GetPourcentage/{idFile}/{idUser}")]
        public IEnumerable<float> GetPourcentageOfProgress(int idFile, string idUser)
        {
            return service.GetPourcentageOfProgress(idFile, idUser);
        }
        [HttpGet]
        [Route("api/VueNumber")]
        public IHttpActionResult GetProgressNumber()
        {
            var query= service.GetProgressNumber();
            if (query == 0)
            {
                return Ok(0);
            }
            else
            {
                return Ok(query);
            }
        }
    }
}
