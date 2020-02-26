using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication5.Models
{
    public class adminviewmodel
    {
        public int Ad_id { get; set; }
        [Display(Name ="Name")]
        [Required(ErrorMessage = "Required")]
        public string Ad_name { get; set; }

        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Required")]
        public string Ad_password { get; set; }
    }
}