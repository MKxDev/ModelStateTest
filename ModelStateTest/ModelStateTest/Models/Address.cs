using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelStateTest.Models
{
    public class Address
    {
        [Required]
        public string Address1 { get; set; }

        public string Address2 { get; set; }
    }
}