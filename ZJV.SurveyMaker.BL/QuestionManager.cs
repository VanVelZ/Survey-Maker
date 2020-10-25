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
    public static class QuestionManager
    {
        public static List<Question> Load()
        {
            try
            {
                List<Question> questions = new List<Question>();
                using(SurveyEntities dc = new SurveyEntities())
                {
                    dc.tblQuestions
                        .ToList()
                        .ForEach(q => questions.Add(new Question
                        {
                            Id = q.Id,
                            Text = q.Question,
                            Answers = AnswerManager.Load(q.Id), 
                            Activator = ActivationManager.GetActivation(q.Id)
                        }));
                }
                return questions;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static Question LoadById(Guid id)
        {
            try
            {
                using(SurveyEntities dc = new SurveyEntities())
                {
                    tblQuestion row = dc.tblQuestions.FirstOrDefault(q => q.Id == id);
                    Question question = new Question { Id = row.Id, Text = row.Question };
                    List<Activation> activations = ActivationManager.Load();
                    question.Activator = activations.FirstOrDefault(a => a.QuestionId == question.Id);

                    if (row != null)
                    {
                        question.Answers = AnswerManager.Load(row.Id);
                    }
                    return question;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static Question LoadByActivationCode(string code)
        {
            using(SurveyEntities dc = new SurveyEntities())
            {
                try
                {
                    var join =
                                from q in dc.tblQuestions
                                join a in dc.tblActivations
                                on q.Id equals a.QuestionId
                                where a.ActivationCode == code
                                select new { Id = q.Id };

                    Question question = LoadById(join.FirstOrDefault().Id);
                    question.Answers = AnswerManager.Load(question.Id);
                    return LoadById(join.FirstOrDefault().Id);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        public static int Insert(Question question, bool rollback = false)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    DbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();
                    tblQuestion newrow = new tblQuestion()
                    {
                        Id = Guid.NewGuid(),
                        Question = question.Text,
                    };
                    dc.tblQuestions.Add(newrow);
                    question.Id = newrow.Id;
                    if (rollback) transaction.Rollback();
                    return dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static int Update(Question question, bool rollback = false)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    DbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();
                    tblQuestion updaterow = dc.tblQuestions.FirstOrDefault(q => q.Id == question.Id);

                    if (updaterow != null)
                    {
                        updaterow.Question = question.Text;
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
                    tblQuestion updaterow = dc.tblQuestions.FirstOrDefault(q => q.Id == id);

                    if (updaterow != null)
                    {
                        dc.tblQuestions.Remove(updaterow);
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
