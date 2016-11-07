using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitAgency.Model
{
    public class Agency : IModifyHistory
    {
        public Agency()
        {
            Persons = new List<Recruiter>();
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

        public int ID { get; set; }

        public bool IsDirty
        {
            get;
            set;
        }

        
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Url { get; set; }
        public string Telephone { get; set; }
        public virtual ICollection<Recruiter> Persons{get;set;}
    }
}
