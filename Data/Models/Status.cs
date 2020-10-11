using czelectronics.Data.Models.MainForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Data.Models
{
    public class Status
    {
        public Status()
        {
            FormUserInput = new HashSet<FormUserInput>();
        }
        public int StatusId { get; set; }
        public string Type { get; set; }
        public virtual ICollection<FormUserInput> FormUserInput { get; set; }
    }
}
