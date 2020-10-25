using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZJV.SurveyMaker.PL;

namespace ZJV.SurveyMaker.PL.Test
{
    [TestClass]
    public class utAnswer
    {
        [TestMethod]
        public void LoadTest()
        {
            using(SurveyEntities dc = new SurveyEntities())
            {
                Assert.AreEqual(dc.tblAnswers.Count(), 6);
            }
        }
        [TestMethod]
        public void InsertTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                dc.tblAnswers.Add(new tblAnswer { Id = Guid.NewGuid(), Answer = "Sandwhich" });
                Assert.AreEqual(1, dc.SaveChanges());
            }
        }
        [TestMethod]
        public void DeleteTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                tblAnswer row = dc.tblAnswers.FirstOrDefault(a => a.Answer == "Sandwhich");
                dc.tblAnswers.Remove(row);
                Assert.AreEqual(1, dc.SaveChanges());
            }
        }
        [TestMethod]
        public void UpdateTest()
        {
            using (SurveyEntities dc = new SurveyEntities())
            {
                tblAnswer row = dc.tblAnswers.FirstOrDefault(a => a.Answer == "Sandwhich");
                if(row != null)row.Answer = "Hero";
                Assert.AreEqual(1, dc.SaveChanges());
            }
        }
    }
}
