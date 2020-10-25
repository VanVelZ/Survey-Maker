using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZJV.SurveyMaker.PL;

namespace ZJV.SurveyMaker.BL
{
    public static class QuestionAnswerManager
    {
        public static int Insert(Guid questionId, Guid answerId, bool iscorrect)
        {
            try
            {
                using(SurveyEntities dc = new SurveyEntities())
                {
                    dc.tblQuestionAnswers.Add(new tblQuestionAnswer { 
                        Id = Guid.NewGuid(), 
                        AnswerId = answerId, 
                        QuestionId = questionId, 
                        IsCorrect = iscorrect 
                    });
                    return dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int Delete(Guid questionId, Guid answerId)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    tblQuestionAnswer row = dc.tblQuestionAnswers.FirstOrDefault(qa => qa.QuestionId == questionId && qa.AnswerId == answerId);
                    dc.tblQuestionAnswers.Remove(row);
                    return dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int Delete(Guid questionId)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    var rows = dc.tblQuestionAnswers.Where(qa => qa.QuestionId == questionId).ToList();
                    rows.ForEach(r => dc.tblQuestionAnswers.Remove(r));
                    return dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
