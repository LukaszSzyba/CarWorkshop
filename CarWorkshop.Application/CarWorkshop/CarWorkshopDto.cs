﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop
{
    public class CarWorkshopDto
    {
        [Required(ErrorMessage = "Huj")]
        [StringLength(20,MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        public string? Description { get; set; }
        public string? About { get; set; }
        [StringLength(12, MinimumLength = 8)]
        public string? PhoneNumber { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }

        public string? EncodedName { get; set; }
    }
}
