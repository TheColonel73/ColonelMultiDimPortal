using System;
using System.Collections.Generic;

namespace RecruitAgency.Model
{
    public class Agency : IModifyHistory
    {
        public Agency()
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

        public int ID { get; set; }

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

        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Url { get; set; }
        public string Telephone { get; set; }
        public virtual ICollection<Person> Persons{get;set;}
    }
}
