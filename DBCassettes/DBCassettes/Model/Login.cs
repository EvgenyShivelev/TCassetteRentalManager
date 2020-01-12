using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBase.Model
{
    public class Login
    {
        [Key]
        public string PersonLogin { get; set; }
        public Person _person { get; set; }
        public string PersonPassword { get; set; }
    }
}
