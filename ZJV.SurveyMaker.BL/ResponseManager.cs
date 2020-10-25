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
    public static class ResponseManager
    {
        public static bool Insert(Response response, bool rollback = false)
        {
            try
            {
                using (SurveyEntities dc = new SurveyEntities())
                {
                    DbContextTransaction transaction = null;
                    if (rollback) transaction = dc.Database.BeginTransaction();
                    tblResponse newrow = new tblResponse()
                    {
                        Id = Guid.NewGuid(),
                        QuestionId = response.QuestionId,
                        AnswerId = response.AnswerId,
                        ResponseDate = response.ResponseDate,
                    };
                    dc.tblResponses.Add(newrow);
                    response.Id = newrow.Id;
                    if (rollback) transaction.Rollback();
                    return dc.SaveChanges() == 1 ? true : false;

                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            
        }
    }
}
