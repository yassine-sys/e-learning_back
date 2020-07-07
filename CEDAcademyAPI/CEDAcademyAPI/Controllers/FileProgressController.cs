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
    [RoutePrefix("api/FileProgress")]
    public class FileProgressController : ApiController
    {
        private IFileProgressService service;

        public FileProgressController(IFileProgressService service)
        {
            this.service = service;
        }
        [HttpPost]
        public HttpResponseMessage AddFileProgress(FileProgress FileProgress)
        {
            service.Add(FileProgress);
            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [HttpGet]
        [Route("ProgressByUserId/{UserId}")]
        public IHttpActionResult GetFileProgressByUserId(string UserId)
        {
            var FileProgress = service.GetFileProgressByUserId(UserId);
            return Ok(FileProgress);
        }
        [HttpPut]
        public IHttpActionResult UpdateFileProgress(FileProgress fp)
        {
            service.Update(fp);
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpGet]
        [Route("{FileProgressId}")]
        public FileProgress GetFileProgressById(int FileProgressId)
        {
            return service.GetById(FileProgressId);
        }
        [HttpGet]
        [Route("FileTrack")]
        public IEnumerable<FileProgress> GetFileProgresses()
        {
            return service.GetFileProgresses();
        }
        [HttpGet]
        [Route("UserPerVideo")]
        public void GetFilesViewsCount()
        {
            service.GetFilesViewsCount();
            
        }
        [HttpGet]
        [Route("GetPourcentage/{idFile}/{idUser}")]
        public IEnumerable<float> GetPourcentageOfProgress(int idFile, string idUser)
        {
            return service.GetPourcentageOfProgress(idFile, idUser);
        }
        [HttpGet]
        [Route("VueNumber")]
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
