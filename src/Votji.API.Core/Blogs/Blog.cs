using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Votji.API.Blogs
{
    public class Blog: Entity<Guid>, IHasCreationTime
    {
        public string Title { get; set; }

        public string Post { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
