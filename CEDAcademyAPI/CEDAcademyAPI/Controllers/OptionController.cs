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
    [RoutePrefix("api/option")]
    public class OptionController : ApiController
    {
        private IOptionService service;

        public OptionController(IOptionService service)
        {
            this.service = service;
        }
        [HttpGet]
        public IEnumerable<Option> GetOptions()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public Option GetOptionById(int id)
        {
            return service.GetById(id);
        }
        [HttpGet]
        [Route("OptionByQuestion/{QuesId}")]
        public IEnumerable<Option> GetOptionsByQuestionId(int QuesId)
        {
            return service.GetOptionsByQuestionId(QuesId);
        }
        [HttpPost]
        public void add(Option o)
        {
            service.Add(o);
        }
        [HttpPut]
        public void update(Option o)
        {
            service.Update(o);
        }
        [HttpDelete]
        public void delete(Option o)
        {
            service.Delete(o);
        }
    }
}
