using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleFw.Core
{
    public class EntityBase
    {
        public string CreatedUserID { get; set; }
        public string UpdatedUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("CreatedUserID")]
        public virtual ApplicationUser CreatedUser { get;set;}

        [ForeignKey("UpdatedUserID")]
        public virtual ApplicationUser UpdatedUser { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
