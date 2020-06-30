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
    public class OptionController : ApiController
    {
        private IOptionService service;

        public OptionController(IOptionService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Route("api/options")]
        public IEnumerable<Option> GetOptions()
        {
            return service.GetAll();
        }
        [HttpGet]
        [Route("api/options/{id}")]
        public Option GetOptionById(int id)
        {
            return service.GetById(id);
        }
        [HttpGet]
        [Route("api/optionbyquestion/{id}")]

        public IEnumerable<Option> GetOptionsByQuestionId(int QuesId)
        {
            return service.GetOptionsByQuestionId(QuesId);
        }
        [HttpPost]
        [Route("api/option/add")]
        public void add(Option o)
        {
            service.Add(o);
        }
        [HttpPut]
        [Route("api/option/update")]

        public void update(Option o)
        {
            service.Update(o);
        }
        [HttpDelete]
        [Route("api/option/delete")]

        public void delete(Option o)
        {
            service.Delete(o);
        }
    }
}
