using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZJV.SurveyMaker.PL.Test
{
    [TestClass]
    public class utQuestionAnswer
    {
        [TestMethod]
        public void LoadTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                Assert.AreEqual(dc.tblQuestionAnswers.Count(), 5);
            }
        }
        [TestMethod]
        public void InsertTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                tblQuestionAnswer row = new tblQuestionAnswer
                {
                    Id = Guid.NewGuid(),
                    AnswerId = dc.tblAnswers.FirstOrDefault(a => a.Answer == "WitchSand").Id,
                    QuestionId = dc.tblQuestions.FirstOrDefault(q => q.Question == "What color is #5254FF").Id,
                    IsCorrect = false
                };
                dc.tblQuestionAnswers.Add(row);
                Assert.AreEqual(1, dc.SaveChanges());
            }
        }
        [TestMethod]
        public void DeleteTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                tblQuestionAnswer row = dc.tblQuestionAnswers.FirstOrDefault(qa => qa.IsCorrect == false);
                dc.tblQuestionAnswers.Remove(row);
                Assert.AreEqual(1, dc.SaveChanges());
            }
        }
        [TestMethod]
        public void UpdateTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                tblQuestionAnswer row = dc.tblQuestionAnswers.FirstOrDefault(qa => qa.IsCorrect == false);
                if (row != null) row.IsCorrect = true;
                Assert.AreEqual(1, dc.SaveChanges());

                //change iscorrect back to false so it can be deleted properly
                row.IsCorrect = false;
                dc.SaveChanges();
            }
        }
    }
}
