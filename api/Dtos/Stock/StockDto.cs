using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using  api.Dtos.Comment;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace api.Dtos.Stock
{
    public class StockDto
    {
         public int Id { get; set; }
         [Required]
        [MinLength(2, ErrorMessage = "Symbol must be 2 characters")]
        [MaxLength(10,ErrorMessage="Symbol cannot be over 10 character")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MinLength(2, ErrorMessage = "Company Name must be 2 characters")]
        [MaxLength(10,ErrorMessage="CompanyName cannot be over 10 character")]
        public string CompanyName { get; set; } = String.Empty;
        public decimal Purchase {get;set;}
       
        public decimal LastDiv {get;set;}
        public string Industry {get;set;} =  string.Empty;
        public long MarketCap{get;set;}
        public List<CommentDto> Comments {get;set;}
   
    }
}