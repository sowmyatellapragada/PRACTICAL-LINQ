using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ
{
   public  class subscriberrepository
    {
        public subscriber Find(List<subscriber> subscriberlist,int SubscriberId)
        {
            subscriber foundsubscriber = null;
            /*var query = from c in subscriberlist
                        where c.SubscriberId == SubscriberId
                        select c;*/
            foundsubscriber = subscriberlist.FirstOrDefault(s => s.SubscriberId == SubscriberId);
            //foundsubscriber=query.First();
            return foundsubscriber;
        }
        public List<subscriber> Retrieve()
        {
            List<subscriber> sublist = new List<subscriber>
            {
                new subscriber()
                {
                    SubscriberId=1,
                    FirstName="sowmya",
                    LastName="T",
                    EmailId="sowmyat@gmail.com" },

                     new subscriber()
                {
                    SubscriberId=2,
                    FirstName="sriram",
                    LastName="Tellapragada",
                    EmailId="sriramt@gmail.com" },
                     new subscriber()
                {
                    SubscriberId=3,
                    FirstName="pranav",
                    LastName="t",
                    EmailId="pranavt@gmail.com" } };

           return sublist;



    }
        public IEnumerable<subscriber> SortByName(List<subscriber> sublist)
        {
            return sublist.OrderBy(s => s.LastName)
                .ThenBy(s=>s.FirstName);
        }
       


    }

        }
