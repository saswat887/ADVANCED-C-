using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [StringLength(20)]
        [RegularExpression(@"^(Finance|HR)$", ErrorMessage = "Enter Valid Department Name")]
        public string DeptName { get; set; }
        [StringLength(20)]
        public string Manager { get; set; }
        public DateTime DepartmentEdit { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }    
    
    }
}
