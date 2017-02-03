using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrinterTonerEPC.Models
{
    public class BaseClass
    {
        public BaseClass()
        {
            this.Created = DateTime.Now;
        }
        /// <summary>
        /// Property that stores current date and time of creation
        /// </summary>
        public DateTime Created { get; set; }
    }
}