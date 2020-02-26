using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication5.Models
{
    public class registrationviewmodel
    {
        public int Stu_reg_id { get; set; }
        [Display(Name ="First-Name")]
        [Required(ErrorMessage = "Required")]
        public string Stu_f_name { get; set; }

        [Display(Name = "Last-Name")]
        [Required(ErrorMessage = "Required")]
        public string Stu_l_name { get; set; }

        [Display(Name = "Father-Name")]
        [Required(ErrorMessage = "Required")]
        public string Stu_father_name { get; set; }

        [Display(Name = "Father-Cnic")]
        [Required(ErrorMessage = "Required")]
        public string stu_father_cnic { get; set; }
        [Display(Name = "Nationality")]
        [Required(ErrorMessage = "Required")]
        public string stu_nationality { get; set; }

        [Display(Name = "R-Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public string stu_reg_date { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Required")]
        public string Stu_gender { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Required")]
        public string Stu_address { get; set; }

        [Display(Name = "Contact")]
        [Required(ErrorMessage = "Required")]
        public string stu_contact { get; set; }

        [Display(Name = "A-Contact")]
        [Required(ErrorMessage = "Required")]
        public string stu_A_Contact { get; set; }

        [Display(Name = "Date-of-Birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public string stu_date_of_birth { get; set; }

        [Display(Name = "Religion")]
        [Required(ErrorMessage = "Required")]
        public string Stu_religion { get; set; }

        [Display(Name = "Class")]
        [Required(ErrorMessage = "Required")]
        public string stu_class { get; set; }
    }
}