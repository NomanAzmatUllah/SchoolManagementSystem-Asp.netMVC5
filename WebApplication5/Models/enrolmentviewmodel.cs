using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication5.Models
{
    public class enrolmentviewmodel
    {
        [Display(Name ="Id")]
        [Required(ErrorMessage = "Required")]
        public int Stu_id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Required")]
        public string Stu_f_name { get; set; }

        [Display(Name = "Last-Name")]
        [Required(ErrorMessage = "Required")]
        public string Stu_l_name { get; set; }

        [Display(Name = "Father-Name")]
        [Required(ErrorMessage = "Required")]
        public string Stu_father_name { get; set; }

        [Display(Name = "Mobile-Number")]
        [Required(ErrorMessage = "Required")]
        public string Stu_father_mobile_Number { get; set; }

        [Display(Name = "Father-Cnic")]
        [Required(ErrorMessage = "Required")]
        public string Stu_father_cnic { get; set; }

        [Display(Name = "Religion")]
        [Required(ErrorMessage = "Required")]
        public string Stu_religion { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Required")]
        public string Stu_gender { get; set; }

        [Display(Name = "Contact")]
        [Required(ErrorMessage = "Required")]
        public string Stu_contact { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Required")]
        public string Stu_address { get; set; }

        [Display(Name = "Date-Of-Birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public string Stu_date_of_birth { get; set; }

        [Display(Name = "Nationality")]
        [Required(ErrorMessage = "Required")]
        public string Stu_nationality { get; set; }

        [Display(Name = "Birth-Place")]
        [Required(ErrorMessage = "Required")]

        public string Stu_birth_place { get; set; }

        [Display(Name = "Emergency-Contact")]
        [Required(ErrorMessage = "Required")]
        public string Stu_Emergency_contact { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Required")]
        public string Stu_city { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Required")]
        public string Stu_email_address { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Required")]
        public string Stu_country { get; set; }

        [Display(Name = "Class")]
        [Required(ErrorMessage = "Required")]
        public string Stu_class { get; set; }
    }
}