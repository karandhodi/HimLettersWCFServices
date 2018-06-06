using System.Collections.Generic;
using System.Linq;

namespace HimLettersWCFService
{

    public class ServicePassword : IServicePassword
    {
       public List<getPass_Results> GetPassword(string Username)
        {
            using (HimLettersEntities entity = new HimLettersEntities())
            {
                return entity.getPass(Username).Select(pe => new getPass_Results
                {
                    Username = pe.Username,
                    Password = pe.Password
                }).ToList();
            }
        }
    }
}
