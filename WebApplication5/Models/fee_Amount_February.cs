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
    
    public partial class fee_Amount_February
    {
        public int fee_id { get; set; }
        public string fee_Advance { get; set; }
        public string Fee_Amount { get; set; }
        public string fee_month_name { get; set; }
        public string fee_status { get; set; }
        public string fee_date { get; set; }
        public Nullable<int> stu_fee_id { get; set; }
    
        public virtual tbl_enrolment tbl_enrolment { get; set; }
    }
}
