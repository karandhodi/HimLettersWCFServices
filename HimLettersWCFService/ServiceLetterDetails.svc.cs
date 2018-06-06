using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace HimLettersWCFService
{

    public class ServiceLetterDetails : IServiceLetterDetails
    {
        /// <summary> 
        /// Method to call getLetterDetail stored procedure
        /// </summary> 
        /// <param name="Id">Id of the required letter details</param> 
        /// <returns>
        /// Returns the letter details corresponding to the given id
        /// </returns>
        public List<getLetterDetail_Results> GetLetterDetails(string Id)
        {
            try
            {
                using (HimLettersEntities entity = new HimLettersEntities())
                {
                    return entity.getLetterDetail(Convert.ToInt32(Id)).Select(pe => new getLetterDetail_Results
                    {
                        Deficient_Day_Range_Start = pe.Deficient_Day_Range_Start,
                        Deficiencies_To_Include = pe.Deficiencies_To_Include,
                        Deficient_Day_Range_End = pe.Deficient_Day_Range_End,
                        Charts_To_Include = pe.Charts_To_Include,
                        Chart_On_Hold = pe.Chart_On_Hold,
                        Include_Visits = pe.Include_Visits,
                        Include_Documents = pe.Include_Documents,
                        Physicians_To_Include = pe.Physicians_To_Include
                    }).ToList();
                }
            }
            catch (Exception ex1)
            {
                LetterDetailsException ex = new LetterDetailsException();
                ex.Title = "Error in ServiceLetterDetails";
                throw new FaultException(ex.Title);
            }
        }
    }
}
