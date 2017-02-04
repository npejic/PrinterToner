﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrinterToner.Models
{
    public class Toner
    {
        public int TonerID { get; set; }
        [Required(ErrorMessage = "Morate uneti model tonera")]
        public int TonerModel { get; set; }
        public bool TonerIsOriginal { get; set; }

        //public virtual ICollection<Sale> Sales { get; set; }
    }
}