using czelectronics.Data.Models.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Data.Models
{
    public class Customer
    {
        public Customer()
        {
            FormUserInput = new HashSet<FormUserInput>();
        }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        //Navigation
        public virtual ICollection<FormUserInput> FormUserInput { get; set; }
    }
}
