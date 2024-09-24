using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{

    internal class Employee
    {
        [Key]
        [RegularExpression("^E'\'d{3}$")]
        [StringLength(10)]
        public string EmpId { get; set; }
        [StringLength(20)]
        public string EmpName { get; set; }
     //   [ForeignKey(Department.DeptID)]
        public int DeptID { get; set; }
        public int Salary { get; set; }
        public DateTime DOB { get; set; }
    }
}
