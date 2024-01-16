using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TypicalTools.Models
{
    public class Comment
    {
        // Sets comment values in database for comment model
        public int CommentId { get; set; }
        [Display(Name = "Comment")]
        public string CommentText { get; set; }
        [Display(Name = "Product Code")]
        [ForeignKey("ProductCode")]
        public int ProductCode { get; set; }
        public string SessionId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;   

    }
}
