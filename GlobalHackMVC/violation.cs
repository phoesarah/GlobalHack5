//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalHackMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class violation
    {
        public short id { get; set; }
        [Display(Name = "Ticket Number")]
        public int citation_number { get; set; }
        [Display(Name = "Ticket Number")]
        public string violation_number { get; set; }
        [Display(Name = "Description")]
        public string violation_description { get; set; }
        [Display(Name = "Warrant Status")]
        public Nullable<bool> warrant_status { get; set; }
        [Display(Name = "Warrant Number")]
        public string warrant_number { get; set; }
        [Display(Name = "Ticket Status")]
        public string status { get; set; }
        [Display(Name = "Ticket Status Date")]
        public Nullable<System.DateTime> status_date { get; set; }
        [Display(Name = "Fine Amount")]
        public Nullable<decimal> fine_amount { get; set; }
        [Display(Name = "Court Cost")]
        public Nullable<decimal> court_cost { get; set; }

        public virtual ICollection<citation> Citations { get; set; }
    }
}
