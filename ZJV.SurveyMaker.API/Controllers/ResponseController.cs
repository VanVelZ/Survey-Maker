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
    public class ResponseController : ApiController
    {
        // POST: api/Response
        public void Post([FromBody] Response response)
        {
            ResponseManager.Insert(response);
        }

    }
}
