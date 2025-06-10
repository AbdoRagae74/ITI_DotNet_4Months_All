using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2.Models
{
    //  [Table("user")]
    public class Employee
    {
        public int id { get; set; }
       [Required]
        [StringLength(50)]
        public string name { get; set; }
        [Column("employeeage")]
        public int? age { get; set; }
        [Column(TypeName ="money")]
        public decimal salary { get; set; }
      //  [StringLength(50)]
        public string password { get; set; }
        [NotMapped]
        public string confirm_password { get; set; }
        public string address { get; set; }

        [ForeignKey("department")]
        public int did { get; set; }
        public virtual Department department { get; set; }

        //  public virtual List<Project> Projects { get;  } = new List<Project>();
        public virtual List<empProj> Projects { get;  } = new List<empProj>();
    }
}
