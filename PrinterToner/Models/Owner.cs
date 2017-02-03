using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrinterTonerEPC.Models
{
    public class Owner : BaseClass
    {
        public int OwnerID { get; set; }
        public string OwnerName { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerContact { get; set; }
        public string OwnerContactTelephone { get; set; }
        public string OwnerTelephone { get; set; }
        public string OwnerPIB { get; set; }
        public string OwnerMatBroj { get; set; }
        public bool OwnerIsInPDV { get; set; }

        public virtual ICollection<Printer> Printers { get; set; }
    }
}