using SampleFw.Data.Admin;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleFw.Data.Common
{
    public class SampleFwEntityBase
    {
        public string CreatedUserId { get; set; }
        public string UpdatedUserId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey("CreatedUserId")]
        public virtual SampleFwUser CreatedUser { get; set; }

        [ForeignKey("UpdatedUserId")]
        public virtual SampleFwUser UpdatedUser { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
