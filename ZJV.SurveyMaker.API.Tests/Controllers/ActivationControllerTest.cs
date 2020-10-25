using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZJV.SurveyMaker.API;
using ZJV.SurveyMaker.API.Controllers;
using ZJV.SurveyMaker.BL.Models;

namespace ZJV.SurveyMaker.API.Tests.Controllers
{
    [TestClass]
    public class ActivationControllerTest
    {
        [TestMethod]
        public void LoadActivationTest()
        {
            ActivationController controller = new ActivationController();
            List<Activation> result = controller.Get() as List<Activation>;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void InsertActivationTest()
        {
            ActivationController controller = new ActivationController();
            QuestionController qcontroller = new QuestionController();
            Question question = qcontroller.Get().Last();
            Activation activation = new Activation { StartDate = DateTime.Now, EndDate = DateTime.Now, ActivationCode = "cccccc", QuestionId = question.Id };
            Assert.AreNotEqual(0, controller.Post(activation));
        }

        [TestMethod]
        public void UpdateActivationTest()
        {
            // Arrange
            ActivationController controller = new ActivationController();
            List<Activation> activations = (List<Activation>)controller.Get();
            Activation Activation = activations.FirstOrDefault(c => c.ActivationCode == "aaaaaa");
            Activation.ActivationCode = "xgfhdd";
            Assert.AreNotEqual(0, controller.Put(Activation.Id, Activation));

        }
    }
}
