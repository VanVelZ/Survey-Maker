using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZJV.SurveyMaker.PL.Test
{
    [TestClass]
    public class utActivation
    {
        [TestMethod]
        public void LoadTest()
        {
            using(SurveyEntities dc = new SurveyEntities())
            {
                Assert.IsTrue(dc.tblActivations.Count() > 0);
            }
        }
    }
}
