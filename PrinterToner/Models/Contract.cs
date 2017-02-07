using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrinterToner.Models
{
    public class Contract
    {
        public int ID { get; set; }
        public string ContractName { get; set; }
        public int ContractDuration { get; set; }
         
        public int OwnerID { get; set; }
        public virtual Owner Owner { get; set; }

        public bool ContractComplete { get; set; }
    }
}