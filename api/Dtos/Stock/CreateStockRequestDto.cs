using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MinLength(2, ErrorMessage = "Symbol must be 2 characters")]
        [MaxLength(10,ErrorMessage="Symbol cannot be over 10 character")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MinLength(2, ErrorMessage = "Company Name must be 2 characters")]
        [MaxLength(10,ErrorMessage="CompanyName cannot be over 10 character")]
        public string CompanyName { get; set; } = String.Empty;
        
        [Required]
        [Range(1,100000000)]
         public decimal Purchase {get;set;}
       [Required]
        [Range(0.001,100)]
        public decimal LastDiv {get;set;}
        [Required]
        [MinLength(2, ErrorMessage = "Indutry must be 2 characters")]
        [MaxLength(15,ErrorMessage="Industry cannot be over 15 character")]
        public string Industry {get;set;} =  string.Empty;
        [Required]
        [Range(1,500000000)]
          public long MarketCap{get;set;}
    }
}