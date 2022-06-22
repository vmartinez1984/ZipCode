using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZipCode.Core.Dtos
{
    public class ZipCodeDtoIn
    {
        [Required]
        [StringLength(5)]
        [MinLength(5)]
        [RegularExpression(@"^\d+$")]
        public string? ZipCode { get; set; }
    }
}