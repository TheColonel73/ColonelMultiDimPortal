using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecruitAgency.Model
{
    public class Person:IModifyHistory
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public ContactType PreferredContactType { get; set; }

        public Person()
        {
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
        public DateTime DateCreated
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime DateModified
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsDirty
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        //[ForeignKey("Agency")]
        //public int Agency_ID { get; set; }
        [Range(0,5)]
        public int Rating { get; set; }
        public virtual Agency Agency { get; set; }

        public virtual ICollection<JobOpportunity> JobOpportunities { get; set; }
    }
}
