using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrinterToner.Models
{
    public class Sale
    {
        public int SaleID { get; set; }
        public DateTime SaleDate { get; set; }
        public float Price { get; set; }
        //public SaleType a { get; set; }
        //public enum SaleType {Pausal, GratisRenta, Else}

        //public int OwnerID { get; set; }
        //public virtual Owner Owner { get; set; }
        
        //public int PrinterID { get; set; }
        //public virtual Printer Printer { get; set; }
        
        //public int TonerID { get; set; }
        //public virtual Toner Toner { get; set; }

    }
}