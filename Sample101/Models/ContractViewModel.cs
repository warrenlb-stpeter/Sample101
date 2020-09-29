using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sample101.Models
{
    public class ContractViewModel
    {
        [DisplayName("Contract No")]
        [Required(ErrorMessage = "This is required.")]
        public string ContractNo { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "This is required.")]
        public string Firstname { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This is required.")]
        public string Lastname { get; set; }

        [DisplayName("Birth Date ")]
        [Required(ErrorMessage = "This is required.")]
        public DateTime Birthdate { get; set; }
    }
}
