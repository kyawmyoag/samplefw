using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleFw.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleFw.Core
{
    [Table("ToDoList")]
    public class ToDoEntity : EntityBase
    {
        [Key]
        public string ID { get; set; }
        public string ToDoName { get; set; }
        public string ToDoDescription { get; set; }
    }
}
