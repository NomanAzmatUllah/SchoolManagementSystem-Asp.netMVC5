//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class atten_may
    {
        public int fee_id { get; set; }
        public string total_days { get; set; }
        public string present { get; set; }
        public string Absents { get; set; }
        public string late { get; set; }
        public string leave { get; set; }
        public Nullable<int> stu_fee_id { get; set; }
    
        public virtual tbl_enrolment tbl_enrolment { get; set; }
    }
}
