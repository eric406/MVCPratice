﻿using System;
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

        [Display(Name = "連絡電話")]
        public string Phone { get; set; }

        [Display(Name = "電子郵件")]
        public string Email { get; set; }
    }
}
