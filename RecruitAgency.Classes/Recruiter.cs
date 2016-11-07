using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecruitAgency.Model
{
    public class Recruiter:IModifyHistory
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public ContactType PreferredContactType { get; set; }

        public Recruiter()
        {
            JobOpportunities = new List<Opportunity>();

        }
        public DateTime DateCreated
        {
            get;
            set;
        }

        public DateTime DateModified
        {
            get;
            set;
        }

        public bool IsDirty
        {
            get;
            set;
        }

        //[ForeignKey("Agency")]
        //public int Agency_ID { get; set; }
        [Range(0,5)]
        public int Rating { get; set; }
        public virtual Agency Agency { get; set; }

        public virtual ICollection<Opportunity> JobOpportunities { get; set; }
    }
}
