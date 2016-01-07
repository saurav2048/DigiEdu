using System;
using System.ComponentModel.DataAnnotations;

namespace Edu.CampusOnCloud.EntityModel.Core
{
    public abstract class AuditBase
    {
        [StringLength(32)]
        public string LastChangedBy { get; set; }
        public DateTime? LastChangedTime { get; set; }
    }
}
