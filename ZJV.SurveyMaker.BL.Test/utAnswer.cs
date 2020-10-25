using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ZJV.SurveyMaker.BL;
using ZJV.SurveyMaker.BL.Models;

namespace ZJV.SurveyMaker.BL.Test
{
    [TestClass]
    public class utAnswer
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(11, AnswerManager.Load().Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            Answer answer = new Answer();
            answer.Id = Guid.NewGuid();
            answer.Text = "Test";
            answer.IsCorrect = false;
            bool results = AnswerManager.Insert(answer, true);
            Assert.IsTrue(results);
        }

        [TestMethod]
        public void UpdateTest()
        {
            List<Answer> answers = AnswerManager.Load();
            Answer answer = answers.FirstOrDefault(a => a.Text == "Waffles");

            answer.Text = "test";
            answer.IsCorrect = false;
            int results = AnswerManager.Update(answer, true);
            Assert.IsTrue(results > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            List<Answer> answers = AnswerManager.Load();
            Answer answer = answers.FirstOrDefault(a => a.Text == "Waffles");

            int results = AnswerManager.Delete(answer.Id, true);
            Assert.IsTrue(results > 0);
        }
    }
}
