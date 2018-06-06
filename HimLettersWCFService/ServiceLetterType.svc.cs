using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace HimLettersWCFService
{
    
    public class ServiceLetterType : IServiceLetterType
    {
        /// <summary> 
        /// Method to call getLetterTypeList stored procedure
        /// </summary> 
        /// <param></param> 
        /// <returns>
        /// Returns the Ids and Names of letter types
        /// </returns>
        public List<getLetterTypeList_Results> GetLetterTypeList()
        {
            try
            {
                using (HimLettersEntities entity = new HimLettersEntities())
                {
                    return entity.getLetterTypeList().Select(pe => new getLetterTypeList_Results
                    {
                        Id = pe.Id,
                        Name = pe.Name
                    }).ToList();
                };
            }
            catch (Exception ex1)
            {
                LetterTypeException ex = new LetterTypeException();
                ex.Title = "Error in ServiceLetterType";
                throw new FaultException(ex.Title);
            }
            
       }
    }
}
