﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootstrapModalTest.Models
{
    public class Person
    {
        
        public int Id{ get; set; }

        [Required]
        [Display(Name="First Name")]
        public string FirstName{ get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName{ get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }
    }
}