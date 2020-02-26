using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebApplication5.Models
{
    public class timetableviewmodel
    {
       
        public int table_id { get; set; }

        [Required(ErrorMessage ="Required")]
        [Display(Name ="Day")]
        public string table_day { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Session 1")]

        public string table_session1 { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Session 2")]

        public string table_session2 { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Session 3")]

        public string table_session3 { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Session 4")]

        public string table_session4 { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Session 5")]

        public string table_session5 { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Session 6")]

        public string table_session6 { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Session 7")]

        public string table_session7 { get; set; }
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Session 8")]

        public string table_session8 { get; set; }
    }
}