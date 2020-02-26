using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication5.Models
{
    public class febamountviewmodel
    {
        [Display(Name = "Fee-Id")]
        [Required(ErrorMessage = "Required")]
        public int fee_id { get; set; }

        [Display(Name = "Lab Charges")]
        [Required(ErrorMessage = "Required")]
        public string fee_Advance { get; set; }

        [Display(Name = "Monthly Amount")]
        [Required(ErrorMessage = "Required")]
        public string Fee_Amount { get; set; }

        [Display(Name = "Payment for The Month")]
        [Required(ErrorMessage = "Required")]
        public string fee_month_name { get; set; }

        [Display(Name = "Paid")]
        [Required(ErrorMessage = "Required")]
        public string fee_status { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public string fee_date { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Required")]
        public Nullable<int> stu_fee_id { get; set; }



    }
}