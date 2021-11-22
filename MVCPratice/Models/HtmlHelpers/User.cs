using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPratice.Models.HtmlHelpers
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name 必須輸入")]
        public string Name { get; set; }
        [Display(Name ="暱稱")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "Password 必須輸入")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int Gender { get; set; }
        public int City { get; set; }
        public string Blog { get; set; }
        public string Commutermode { get; set; }
        public string Comment { get; set; }
        public bool Terms { get; set; }
    }
}
