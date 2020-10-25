using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ZJV.SurveyMaker.BL;
using ZJV.SurveyMaker.BL.Models;

namespace ZJV.SurveyMaker.BL.Test
{
    [TestClass]
    public class utActivation
    {
        [TestMethod]
        public void LoadTest()
        {
            Assert.AreEqual(4, ActivationManager.Load().Count);
        }

        [TestMethod]
        public void InsertTest()
        {
            List<Question> questions = QuestionManager.Load();
            Question ques = questions.FirstOrDefault(q => q.Text == "What color is #DFFF52");
            Activation activation = new Activation();
            activation.Id = Guid.NewGuid();
            activation.QuestionId = ques.Id;
            activation.StartDate = DateTime.Now;
            activation.EndDate = DateTime.Now;
            activation.ActivationCode = "eeeee";
            int results = ActivationManager.Insert(activation, true);
            Assert.IsTrue(results > 0);
        }

        [TestMethod]
        public void UpdateTest()
        {
            List<Activation> activations = ActivationManager.Load();
            Activation activation = activations.FirstOrDefault(a => a.ActivationCode == "aaaaa");

            activation.ActivationCode = "test";

            int results = ActivationManager.Update(activation, true);
            Assert.IsTrue(results > 0);
        }

        [TestMethod]
        public void DeleteTest()
        {
            List<Activation> activations = ActivationManager.Load();
            Activation activation = activations.FirstOrDefault(a => a.ActivationCode == "aaaaa");

            int results = ActivationManager.Delete(activation.Id, true);
            Assert.IsTrue(results > 0);
        }
    }
}
