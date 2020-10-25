using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ZJV.SurveyMaker.BL;
using ZJV.SurveyMaker.BL.Models;

namespace ZJV.SurveyMaker.BL.Test
{
    /// <summary>
    /// Summary description for utQuestion
    /// </summary>
    [TestClass]
    public class utQuestion
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.IsTrue(QuestionManager.Load().Count > 0);
        }

        [TestMethod]
        public void InsertTest()
        {
            Question question = new Question();
            question.Id = Guid.NewGuid();
            question.Text = "Test";
            int results = QuestionManager.Insert(question, true);
            Assert.IsTrue(results > 0);
        }

        [TestMethod]
        public void UpdateTest()
        {
            List<Question> questions = QuestionManager.Load();
            Question question = questions.FirstOrDefault(a => a.Text == "What color is #51DFFF");

            question.Text = "test";
            int results = QuestionManager.Update(question, true);
            Assert.IsTrue(results > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            List<Question> questions = QuestionManager.Load();
            Question question = questions.FirstOrDefault(a => a.Text == "What color is #51DFFF");

            int results = QuestionManager.Delete(question.Id, true);
            Assert.IsTrue(results > 0);
        }
    }
}
