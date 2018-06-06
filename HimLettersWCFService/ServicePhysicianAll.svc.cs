using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace HimLettersWCFService
{

    public class ServicePhysicianAll : IServicePhysicianAll
    {
        public List<getPhysiciansList_Results> GetPhysicianList(string letterTypeId)
        {
            try
            {
                using (HimLettersEntities entity = new HimLettersEntities())
                {
                    return entity.getPhysiciansListAll(Convert.ToInt32(letterTypeId)).Select(pe => new getPhysiciansList_Results
                    {
                        Email = pe.Email,
                        Name = pe.Name,
                        Fax = pe.Fax
                    }).ToList();
                }
            }
            catch (Exception ex1)
            {
                PhysicianAllException ex = new PhysicianAllException();
                ex.Title = "Error in ServicePhysicianAll";
                throw new FaultException(ex.Title);
            }
        }
    }
}
