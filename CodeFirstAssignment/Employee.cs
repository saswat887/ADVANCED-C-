using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment
{
    public class Employee
    {
        [Key]
        [RegularExpression(@"^E\d{3}$",ErrorMessage ="Enter Valid ID") ]
        [StringLength(10,ErrorMessage = "Enter Valid ID")]
        public string EmpId { get; set; }
        [StringLength(20,ErrorMessage = "Enter Valid Name")]
        public string EmpName { get; set; }
      
        public virtual Department DeptId { get; set; }
        [Range(50000,150000, ErrorMessage = "Enter in Valid Range")]
        public int Salary { get; set; }
        public DateTime DOB { get; set; }
    }
}
