using System;

namespace RecruitAgency.Model
{
    /// <summary>
    /// Job is the employment Opportunity
    /// </summary>
    public class JobOpportunity:IModifyHistory
    {
        public JobOpportunity()
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

        public string Notes { get; set; }
        //public virtual Person RecruitPerson { get; set; }
    }
}
