using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using czelectronics.Data.Models.MainForm;

namespace czelectronics.Data.Models
{
    public class StoreCode
    {
        public StoreCode()
        {
            FormUserInput = new HashSet<FormUserInput>();
        }
        public int StoreCodeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<FormUserInput> FormUserInput { get; set; }
    }
}
