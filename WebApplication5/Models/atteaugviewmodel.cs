using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication5.Models
{
    public class atteaugviewmodel
    {
        public int fee_id { get; set; }

        [Display(Name = "Total-Days")]
        [Required(ErrorMessage = "Required")]
        public string total_days { get; set; }

        [Display(Name = "Present-Days")]
        [Required(ErrorMessage = "Required")]
        public string present { get; set; }

        [Display(Name = "Absent-Days")]
        [Required(ErrorMessage = "Required")]
        public string Absents { get; set; }

        [Display(Name = "Late")]
        [Required(ErrorMessage = "Required")]
        public string late { get; set; }

        [Display(Name = "Leave")]
        [Required(ErrorMessage = "Required")]
        public string leave { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Required")]
        public Nullable<int> stu_fee_id { get; set; }
    }
}
    
