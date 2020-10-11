using czelectronics.Data.Models.MainForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace czelectronics.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ModelNumber { get; set; }
        public string SerialNumber { get; set; }
        public string FaultInspection { get; set; }
        public string FaultDescription { get; set; }
        public string ArticleNumber { get; set; }
        public bool Accessories { get; set; }
        public bool Box { get; set; }
        public bool Remote { get; set; }
        public bool Manual { get; set; }

        //Fk
        public int ProductTypeId { get; set; }
        public int FormUserInputId { get; set; }

        //Navigation
        public virtual FormUserInput FormUserInput { get; set; }
        public virtual ProductType ProductTypeNavigation { get; set; }
    }
}
