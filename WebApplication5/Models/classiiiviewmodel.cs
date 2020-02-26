using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication5.Models
{
    public class classiiiviewmodel
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage ="Required")]
        public int cous_id { get; set; }

        [Display(Name = "Course-Name")]
        [Required(ErrorMessage = "Required")]
        public string cous_name { get; set; }
    }
}