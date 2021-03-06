﻿using System;

namespace RecruitAgency.Model
{
    /// <summary>
    /// Job is the employment Opportunity
    /// </summary>
    public class Opportunity:IModifyHistory
    {
        public Opportunity()
        {

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

        public string Notes { get; set; }
        //public virtual Person RecruitPerson { get; set; }
    }
}
