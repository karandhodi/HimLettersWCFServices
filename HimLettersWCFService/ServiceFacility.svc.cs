using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace HimLettersWCFService
{

    public class ServiceFacility : IServiceFacility
    {
        /// <summary> 
        /// Method to call getFacility stored procedure
        /// </summary> 
        /// <param></param> 
        /// <returns>
        /// Returns the Ids and Names of facilities
        /// </returns>
        public List<getFacility_Results> GetFacility()
        {
            try
            {
                using (HimLettersEntities entity = new HimLettersEntities())
                {
                    return entity.getFacility().Select(pe => new getFacility_Results
                    {
                        Id = pe.Id,
                        Facility_Name = pe.Facility_Name
                    }).ToList();
                }
            }
            catch (Exception ex1)
            {
                FacilityException ex = new FacilityException();
                ex.Title = "Error in ServiceFacility";
                throw new FaultException(ex.Title);
            }
        }
    }
}
