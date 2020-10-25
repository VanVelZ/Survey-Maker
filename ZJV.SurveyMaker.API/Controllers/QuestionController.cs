using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZJV.SurveyMaker.BL;
using ZJV.SurveyMaker.BL.Models;

namespace ZJV.SurveyMaker.API.Controllers
{
    public class QuestionController : ApiController
    {
        // GET: api/Question
        public IEnumerable<Question> Get()
        {
            return QuestionManager.Load();
        }
        // GET: api/Question
        public Question LoadByActivationCode(string code)
        {
            return QuestionManager.LoadByActivationCode(code);
        }

        // GET: api/Question/5
        public Question Get(Guid id)
        {
            return QuestionManager.LoadById(id);
        }

        // POST: api/Question
        public void Post([FromBody]Question value)
        {
            QuestionManager.Insert(value);
        }

        // PUT: api/Question/5
        public void Put(Guid id, [FromBody]Question value)
        {
            QuestionManager.Update(value);
        }

    }
}
