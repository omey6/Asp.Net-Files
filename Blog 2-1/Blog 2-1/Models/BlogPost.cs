using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Blog_2_1.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Post Title")]
        public string BlogTitle { get; set; }
        [Display(Name = "Write Blog Post Below")]
        public string Content { get; set; }
        [Display(Name = "Date")]
        public DateTime BlogDate { get; set; }
    }
}