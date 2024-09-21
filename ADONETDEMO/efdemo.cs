using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETDEMO
{
    internal class efdemo
    {
        studentsdbEntities dc = new studentsdbEntities();
        Repo r=new Repo();
        public void DisplayStudents()
        {
            dc.Database.Log=Console.WriteLine;
            var res = from t in dc.students
                      select t;
            foreach (var t in res)
            {
                Console.WriteLine($"{t.studentid} {t.studentname} {t.sclass} {t.saddress}");

            }
        }
        public void DisplayStudentsbyId()
        {
            Console.WriteLine("Enter id");
            int x = int.Parse(Console.ReadLine());
            /*    var res=(from t in dc.students
                        where t.studentid==x
                        select t).FirstOrDefault();*/


            //     var res = dc.students.Where(t => t.studentid == x).FirstOrDefault();
            var res=r.Search<student>(x);


            Console.WriteLine($"{res.studentid} {res.studentname} {res.sclass} {res.saddress}");
        }
        public void AddnewStudents()
        {
            try
            {
                student s = new student()
                {
                    studentid = 101,
                    studentname = "saswat",
                    sclass = 4,
                    saddress = "Pune"
                };
              /* dc.students.Add(s);
                int i = dc.SaveChanges();
                Console.WriteLine(1 + ":record insertion successfull");*/
                r.Add(s);
            }
            catch (Exception ex)
            {
                var res = dc.GetValidationErrors();
                foreach(var items in res)
                {
                    if(items.ValidationErrors.Count > 0)
                    {
                        foreach(var error in items.ValidationErrors)
                        {
                            Console.WriteLine(error.ErrorMessage);
                        }
                    }
                }
            }
        }
        public void deletestudents()
        {
            Console.WriteLine("Enter id");
            int id = int.Parse(Console.ReadLine());
            /* var res = dc.students.Where(t => t.studentid == id).FirstOrDefault();
               dc.students.Remove(res);
               int i = dc.SaveChanges();
               Console.WriteLine(1 + ":record deletion successfull");*/
            r.Delete<student>(id);

        }
        public void editstudents()
        {
            Console.WriteLine("Enter id");
            int id = int.Parse(Console.ReadLine());
            var res = dc.students.Where(t => t.studentid == id).FirstOrDefault();

            res.saddress = "banglore";
            int i = dc.SaveChanges();
            Console.WriteLine(1 + ":record update successfull");

        }
        public void showproc()
        {
            Console.WriteLine("enter address");
            string st = Console.ReadLine();
            var res = dc.displaysstudentsbyaddress(st);
            foreach (var t in res)
            {
                Console.WriteLine($"{t.studentid} {t.studentname} {t.sclass} {t.saddress}");

            }
        }
        public void showdetails()
        {
            //display 2tables
            //var res = from t in dc.students
            //           from t1 in dc.courses
            //           where t.studentid == t1.studentid && t.saddress== "banglore" && t1.duration==3
            //           select new { t.studentid, t.studentname, t1.coursename,t1.duration ,t.saddress};

            var res = from t in dc.students join t1 in dc.courses
                      on t.studentid equals t1.studentid
                      select new { t.studentid, t.studentname, t1.coursename, t1.duration, t.saddress };

            foreach (var t in res)
            {
                Console.WriteLine($"{t.studentid} {t.studentname} {t.coursename} {t.duration} {t.saddress}");

            }
        }
        public void showrecords()
        {
            dc.Database.Log = Console.WriteLine;
            var res = from t in dc.students
                      select t;

            foreach(var t in res)
            {
                Console.WriteLine($"{t.studentid} {t.studentname} ");
                foreach(var i in t.courses)
                {
                    Console.WriteLine($"{i.courseid} {i.coursename}");
                }
            }


        }
    }
}