using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace api.Dtos.Comment
{
    public class UpdateCommentRequestDto
    {
        
        [Required]
        [MinLength(2, ErrorMessage = "Title must be 5 characters")]
        [MaxLength(200,ErrorMessage="Title cannot be over 200 character")]
        public string Title { get; set; } =  string.Empty;
        [Required]
        [MinLength(2, ErrorMessage = "Content must be 5 characters")]
        [MaxLength(200,ErrorMessage="Content cannot be over 200 character")]
        public string Content { get; set; } = string.Empty;
       
    }
}