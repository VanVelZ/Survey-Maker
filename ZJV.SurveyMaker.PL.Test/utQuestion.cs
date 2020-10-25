using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZJV.SurveyMaker.PL.Test
{
    [TestClass]
    public class utQuestion
    {
        [TestMethod]
        public void LoadTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                Assert.AreEqual(dc.tblQuestions.Count(), 5);
            }
        }
        [TestMethod]
        public void InsertTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                dc.tblQuestions.Add(new tblQuestion { Id = Guid.NewGuid(), Question = "???" });
                Assert.AreEqual(1, dc.SaveChanges());
            }
        }
        [TestMethod]
        public void DeleteTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                tblQuestion row = dc.tblQuestions.FirstOrDefault(a => a.Question == "???");
                dc.tblQuestions.Remove(row);
                Assert.AreEqual(1, dc.SaveChanges());
            }
        }
        [TestMethod]
        public void UpdateTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                tblQuestion row = dc.tblQuestions.FirstOrDefault(a => a.Question == "???");
                if (row != null) row.Question = "Hero";
                Assert.AreEqual(1, dc.SaveChanges());
            }
        }
    }
}
