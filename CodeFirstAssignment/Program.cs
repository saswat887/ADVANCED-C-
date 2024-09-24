using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model1 m = new Model1();
            try
            {
               
                Department d = new Department()
                {
                    DeptId = 1,
                    DeptName = "HR",
                    Manager = "Srini",
                    DepartmentEdit = new DateTime(2024, 12, 12)
                };
                Employee employee = new Employee()
                {
                    EmpId = "E1256",
                    EmpName = "Saswat",
                    Salary = 100000,
                    DOB = new DateTime(2000, 12, 12),
                    DeptId = d



                };
                //    m.Departments.Add(d);
                m.Employees.Add(employee);
                m.SaveChanges();
            }
            catch (Exception ex) {
                var res = m.GetValidationErrors();
                foreach (var items in res)
                {
                    if (items.ValidationErrors.Count > 0)
                    {
                        foreach (var error in items.ValidationErrors)
                        {
                            Console.WriteLine(error.ErrorMessage);
                        }
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
