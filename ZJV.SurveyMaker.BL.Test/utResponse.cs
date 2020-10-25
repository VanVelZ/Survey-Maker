using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ZJV.SurveyMaker.BL;
using ZJV.SurveyMaker.BL.Models;

namespace ZJV.SurveyMaker.BL.Test
{
    [TestClass]
    public class utResponse
    {
        [TestMethod]
        public void InsertTest()
        {
            List<Question> questions = QuestionManager.Load();
            Question question = questions.FirstOrDefault(a => a.Text == "What color is #51DFFF");
            List<Answer> answers = AnswerManager.Load();
            Answer answer = answers.FirstOrDefault(a => a.Text == "Waffles");

            Response response = new Response();
            response.Id = Guid.NewGuid();
            response.AnswerId = answer.Id;
            response.QuestionId = question.Id;
            response.ResponseDate = DateTime.Now;
            bool results = ResponseManager.Insert(response, true);
            Assert.IsTrue(results);
        }
    }
}
