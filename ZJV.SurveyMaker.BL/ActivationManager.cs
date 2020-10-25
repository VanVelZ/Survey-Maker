using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZJV.SurveyMaker.BL.Models;
using ZJV.SurveyMaker.PL;

namespace ZJV.SurveyMaker.BL
{
    public static class ActivationManager
    {
        public static List<Activation> Load()
        {
            try
            {
                List<Activation> activations = new List<Activation>();
                using (SurveyEntities dc = new SurveyEntities())
                {
                    dc.tblActivations
                        .ToList()
                        .ForEach(a => activations.Add(new Activation
                        {
                            Id = a.Id,
                            QuestionId = a.QuestionId,
                            StartDate = a.StartDate,
                            EndDate = a.EndDate,
                            ActivationCode = a.ActivationCode
                        }));
                }
                return activations;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static Activation GetActivation(Guid questionId)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    tblActivation row = new tblActivation();
                    row = dc.tblActivations.FirstOrDefault(q => q.QuestionId == questionId);
                    if (row == null)
                    {
                        return null;
                    }
                    Activation activation = new Activation { 
                        Id = row.Id, QuestionId = row.QuestionId, StartDate = row.StartDate, EndDate = row.EndDate, ActivationCode = row.ActivationCode
                    };

                    return activation;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int Insert(Activation activation, bool rollback = false)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    DbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();
                    tblActivation newrow = new tblActivation()
                    {
                        Id = Guid.NewGuid(),
                        QuestionId = activation.QuestionId,
                        StartDate = activation.StartDate,
                        EndDate = activation.EndDate,
                        ActivationCode = activation.ActivationCode
                    };
                    dc.tblActivations.Add(newrow);
                    activation.Id = newrow.Id;
                    if (rollback) transaction.Rollback();
                    return dc.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public static int Update(Activation activation, bool rollback = false)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    DbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();
                    tblActivation updaterow = dc.tblActivations.FirstOrDefault(q => q.Id == activation.Id);

                    if (updaterow != null)
                    {
                        updaterow.QuestionId = activation.QuestionId;
                        updaterow.StartDate = activation.StartDate;
                        updaterow.EndDate = activation.EndDate;
                        updaterow.ActivationCode = activation.ActivationCode;
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
                    tblActivation updaterow = dc.tblActivations.FirstOrDefault(q => q.Id == id);

                    if (updaterow != null)
                    {
                        dc.tblActivations.Remove(updaterow);
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
