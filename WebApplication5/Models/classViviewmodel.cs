using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication5.Models
{
    public class classViviewmodel
    {
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Id")]
        public int cous_id { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Course-Name")]
        public string cous_name { get; set; }
    }
}