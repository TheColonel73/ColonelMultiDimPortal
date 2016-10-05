using System;

namespace RecruitAgency.Model
{
    public interface IModifyHistory
    {
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
        bool IsDirty { get; set; }

    }
}
