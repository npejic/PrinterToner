using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PrinterTonerEPC.Models;
using System.Data.Entity;

namespace PrinterTonerEPC.DAL
{
    public class PrinterTonerContext : DbContext
    {
        public PrinterTonerContext() : base("PrinterTonerContext") { }

         public DbSet<Owner> Owners { get; set; }

         public System.Data.Entity.DbSet<PrinterTonerEPC.Models.Printer> Printers { get; set; }
    }
}