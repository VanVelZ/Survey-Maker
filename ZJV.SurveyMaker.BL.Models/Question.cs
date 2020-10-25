using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZJV.SurveyMaker.BL.Models
{
    public class Question
    {
        //Added classes as properties
        public Activation Activator { get; set; }
        public Response Response { get; set; }

        public Guid Id { get; set; }
        public List<Answer> Answers { get; set; }
        public String Text { get; set; }

    }
}
