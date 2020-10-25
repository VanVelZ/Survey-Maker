using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZJV.SurveyMaker.BL.Models;
using ZJV.SurveyMaker.PL;

namespace ZJV.SurveyMaker.BL
{
    public static class AnswerManager
    {
        public static List<Answer> Load()
        {
            try
            {
                List<Answer> answers = new List<Answer>();
                using (SurveyEntities dc = new SurveyEntities())
                {
                    dc.tblAnswers
                        .ToList()
                        .ForEach(a => answers.Add(new Answer
                        {
                            Id = a.Id,
                            Text = a.Answer
                        }));
                }
                return answers;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static List<Answer> Load(Guid questionId)
        {
            try
            {
                List<Answer> answers = new List<Answer>();
                using (SurveyEntities dc = new SurveyEntities())
                {
                    var join =
                        from answer in dc.tblAnswers
                        join qa in dc.tblQuestionAnswers on answer.Id equals qa.AnswerId
                        where qa.QuestionId == questionId
                        select new { AnswerId = answer.Id, Text = answer.Answer, isCorrect = qa.IsCorrect };

                    join
                        .ToList()
                        .ForEach(a => answers.Add(new Answer
                        {
                            Id = a.AnswerId,
                            Text = a.Text,
                            IsCorrect = a.isCorrect
                        }));
                }
                return answers;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static Answer LoadById(Guid id)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    tblAnswer row = dc.tblAnswers.FirstOrDefault(a => a.Id == id);
                    Answer answer = new Answer { Id = row.Id, Text = row.Answer };

                    return answer;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static bool Insert(Answer answer, bool rollback = false)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    DbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();
                    tblAnswer newrow = new tblAnswer()
                    {
                        Id = Guid.NewGuid(),
                        Answer = answer.Text,
                    };
                    dc.tblAnswers.Add(newrow);
                    answer.Id = newrow.Id;
                    if (rollback) transaction.Rollback();
                    return dc.SaveChanges() == 1 ? true : false;

                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public static int Update(Answer answer, bool rollback = false)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    DbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();
                    tblAnswer updaterow = dc.tblAnswers.FirstOrDefault(a => a.Id == answer.Id);

                    if (updaterow != null)
                    {
                        updaterow.Answer = answer.Text;
                    }
                    else
                    {
                        throw new Exception("Row was not found");
                    }
                    if (rollback) transaction.Rollback();
                    return dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int Delete(Guid id, bool rollback = false)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    DbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();
                    tblAnswer deleterow = dc.tblAnswers.FirstOrDefault(a => a.Id == id);

                    if (deleterow != null)
                    {
                        dc.tblAnswers.Remove(deleterow);
                    }
                    else
                    {
                        throw new Exception("Row was not found");
                    }
                    if (rollback) transaction.Rollback();
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
