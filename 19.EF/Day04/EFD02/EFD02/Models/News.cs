using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD02.Models
{
    public class News
    {
        public int ID { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Brief { get; set; }
        public string Description { get; set; }
        public DateTime NewsDate { get; set; }
        [ForeignKey("CategoryNavProp")]
        public int CategoryID { get; set; }
        [ForeignKey ("AuthorNavProp")]
        public int AuthorID { get; set; }

        public virtual Author AuthorNavProp { get; set; }
        public virtual Category CategoryNavProp { get; set; }

    }
}
