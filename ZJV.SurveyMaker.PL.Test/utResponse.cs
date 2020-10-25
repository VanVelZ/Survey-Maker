using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZJV.SurveyMaker.PL.Test
{
    [TestClass]
    public class utResponse
    {
        [TestMethod]
        public void LoadTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                Assert.AreEqual(dc.tblResponses.Count(), 6);
            }
        }
        [TestMethod]
        public void InsertTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                tblResponse row = new tblResponse
                {
                    Id = Guid.NewGuid(),
                    AnswerId = dc.tblAnswers.FirstOrDefault(a => a.Answer == "Waffles").Id,
                    QuestionId = dc.tblQuestions.FirstOrDefault(q => q.Question == "What color is #DFFF52").Id,
                    ResponseDate = DateTime.Now
                };
                dc.tblResponses.Add(row);
                Assert.AreEqual(1, dc.SaveChanges());
            }
        }
    }
}
