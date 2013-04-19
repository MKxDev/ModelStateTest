using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelStateTest.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }

        public Address Address { get; set; }
    }
}