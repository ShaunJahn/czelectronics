using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Data.Models.MainForm
{
    public class FormUserInput
    {
        public int FormUserInputId { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public int QuantityOfUnits { get; set; }
        public bool DiscussedFaults { get; set; }
        public bool WarrantyVerified { get; set; }

        //Fk Keys
        public int StoreCodeId { get; set; }
        public int CustomerId { get; set; }
        public int StatusId { get; set; } = 1;

        //Navigation Functions
        public virtual StoreCode StoreCode { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Status Status { get; set; }

        public virtual ICollection<Product> ProductsNavigation { get; set; }
    }
}
