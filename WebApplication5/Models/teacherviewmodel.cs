using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class teacherviewmodel
    {
        [Display(Name ="Id")]
        [Required(ErrorMessage ="Required")]
        public int teacher_id { get; set; }

        [Display(Name ="Teacher-Name")]
        [Required(ErrorMessage = "Required")]
        public string teacher_name { get; set; }

        [Display(Name ="Appoinment Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public string Teacherjoin_date { get; set; }
        [Display(Name ="Qualification")]
        [Required(ErrorMessage = "Required")]
        public string Qualification { get; set; }

        [Display(Name ="Subject")]
        [Required(ErrorMessage = "Required")]
        public string Teaching_course { get; set; }

        [Display(Name ="Contact")]
        [Required(ErrorMessage = "Required")]
        public string teacher_contact { get; set; }

        [Display(Name ="Salary")]
        [Required(ErrorMessage = "Required")]
        public string teacher_monthly_salary { get; set; }
    }
}