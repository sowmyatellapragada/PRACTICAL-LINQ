using System.Collections.Generic;
using LINQ;

namespace LINQ
{
    public class subscribertyperepository
    {
        public List<subscribertype> Retrieve()
        {
            List<subscribertype> subscribertypelist= new List<subscribertype>()

            {
                new subscribertype {  subscribertypeid= 1, TypeName = "Corporate", DisplayVideo = 2 },
                new subscribertype {  subscribertypeid = 2, TypeName = "Individual", DisplayVideo = 1 },
                new subscribertype {  subscribertypeid= 3, TypeName = "Educator", DisplayVideo = 4 },
                new subscribertype { subscribertypeid = 4, TypeName = "Government",DisplayVideo = 3 }
            };
            return subscribertypelist;
        }
    }
}