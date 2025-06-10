using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2.Models
{
    [PrimaryKey(nameof(empid) ,nameof(projid))]//dotnetcore >7
    public class empProj
    {
        [ForeignKey("employee") ]
      //  [Key,Column(Order =1)].net framework
        public int empid { get; set; }
        [ForeignKey("project")]
        //  [Key, Column(Order = 2)].net framework

        public int projid { get; set; }

        public virtual Employee employee { get; set; }
        public virtual Project project { get; set; }
    }
}
