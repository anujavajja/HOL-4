using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HOL_4.Models
{
    public class Account
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, long.MaxValue, ErrorMessage = "Account number cannot be negative or zero")]

        [Remote("CheckAccountNumber", "Home")]
        public int AccountNumber { get; set; }

        [StringLength(byte.MaxValue, MinimumLength = 2, ErrorMessage = "MinimumLength must be 500")]
        public string Name { get; set; }

        [Range(500, long.MaxValue, ErrorMessage = "Minimum balance must be 500")]
        public double CurrentBalance { get; set; }
    }
}