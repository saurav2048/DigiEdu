using System;
using System.ComponentModel.DataAnnotations;

namespace Common.EntityModel.User
{
    public abstract class AuditBase
    {
        [StringLength(32)]
        public string LastChangedBy { get; set; }
        public DateTime? LastChangedTime { get; set; }
    }
}
