using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProftaakDemo.Models
{
    public class Post : IPost
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Titel is te lang")]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }

    }
}
