using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPratice.Models
{
    public class Student
    {
        [Display(Name = "學號")]
        public int Id { get; set; }

        [Display(Name = "名字")]
        public string Name { get; set; }

        [Display(Name = "國文")]
        public int Chinese { get; set; }

        [Display(Name = "英文")]
        public int English { get; set; }

        [Display(Name = "數學")]
        public int Math { get; set; }
        [Display(Name = "總計")]
        public int Total { get; set; }
    }
}
