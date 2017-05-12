using Mikolo.CoreNet.Profil.Entity.User;
using System;

namespace Mikolo.CoreNet.Base.Entity
{
    public abstract class Content
    {
        protected Guid ContentId { get; set; }

        protected string SeoTitle { get; set; }

        protected string SeoDescription { get; set; }

        protected DateTime CreatedOn { get; set; }

        protected User CreatedBy { get; set; }

        protected DateTime UpdatedOn { get; set; }

        protected User UpdatedBy { get; set; }

    }
}
