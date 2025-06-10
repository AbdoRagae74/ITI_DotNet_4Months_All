using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFday2Task.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string? Brief { get; set; }
        public string? Description { get; set; }
        public DateTime? PublishDate { get; set; }
        


        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}