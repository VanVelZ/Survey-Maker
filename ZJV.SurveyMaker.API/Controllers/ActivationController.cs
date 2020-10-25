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
    public class ActivationController : ApiController
    {
        // GET: api/Activation
        public IEnumerable<Activation> Get()
        {
            return ActivationManager.Load();
        }
        public Activation GetByQuestionId(Guid questionid)
        {
            return ActivationManager.GetActivation(questionid);
        }
        // POST: api/Activation
        public int Post([FromBody]Activation value)
        {
            return ActivationManager.Insert(value);
        }

        // PUT: api/Activation/5
        public int Put(Guid id, [FromBody]Activation value)
        {
            return ActivationManager.Update(value);
        }
        // Delete: api/Activation/5
        public int Delete(Guid id)
        {
            return ActivationManager.Delete(id);
        }

    }
}
