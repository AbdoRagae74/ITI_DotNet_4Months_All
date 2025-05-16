using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD02.Models
{
    public class Category
    {
        public int ID { get; set; }
        [StringLength(20)]

        public string Name { get; set; }
        [StringLength(80)]

        public string Description { get; set; }
        public virtual List<News> news { get; set; } = new List<News>();
    }
}
