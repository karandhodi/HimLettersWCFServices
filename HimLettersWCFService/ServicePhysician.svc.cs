using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace HimLettersWCFService
{

    public class ServicePhysician : IServicePhysician
    {
        /// <summary> 
        /// Method to call getPhysiciansList stored procedure
        /// </summary> 
        /// <param name="letterTypeId">Id of the letter type</param> 
        /// <param name="facilityId">Id of the facility</param> 
        /// <returns>
        /// Returns the physician details corresponding to given letter type id and facility id
        /// </returns>
        public List<getPhysiciansList_Results> GetPhysicianList(string letterTypeId, string facilityId)
        {
            try
            {
                using (HimLettersEntities entity = new HimLettersEntities())
                {
                    return entity.getPhysiciansList(Convert.ToInt32(letterTypeId), Convert.ToInt32(facilityId)).Select(pe => new getPhysiciansList_Results
                    {
                        Email = pe.Email,
                        Name = pe.Name,
                        Fax = pe.Fax
                    }).ToList();
                }
            }
            catch (Exception ex1)
            {
                PhysicianException ex = new PhysicianException();
                ex.Title = "Error in ServicePhysician";
                throw new FaultException(ex.Title);
            }
        }
    }
}
