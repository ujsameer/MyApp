using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApp.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public DateTime LocationDate { get; set; }
        public string LocationName { get; set; }
        public decimal Amount { get; set; }
        public string TransactionBy { get; set; }  
    }
}