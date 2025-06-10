using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFday2Task.Models
{
    public class Author
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string? Email { get; set; }
        public virtual List<News> News { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
