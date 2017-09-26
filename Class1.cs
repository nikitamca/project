using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace OMS.Models
{
    public class Class1
    {
        [Key]
        public int eid { get; set; }

        [Required]
        public string ename { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string cpassword { get; set; }
        public int mono { get; set; }
    }
}