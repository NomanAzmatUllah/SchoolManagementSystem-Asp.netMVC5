using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication5.Models
{
    public class eventviwmodel
    {
        [Display(Name ="Id")]
        [Required(ErrorMessage = "Required")]
        public int enents_id { get; set; }
        [Display(Name ="Name")]
        [Required(ErrorMessage = "Required")]
        public string events_name { get; set; }

        [Display(Name ="Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Required")]
        public string event_date { get; set; }
        [Display(Name = "Time")]
        [Required(ErrorMessage = "Required")]
        public string event_time { get; set; }
        [Display(Name = "Day")]
        [Required(ErrorMessage = "Required")]
        public string event_day { get; set; }
    }
}