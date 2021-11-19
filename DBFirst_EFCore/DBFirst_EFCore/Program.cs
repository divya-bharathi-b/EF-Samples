// See https://aka.ms/new-console-template for more information
using DBFirst_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst_EFCore
{
   class Program
    {
        static void Main(string[] args)
        {
            //AddNewEmployee();
            //GetAllEmployee();
            //GetEmployeeByID();
            // UpdateEmpByEmpID();
            //DeleteEmpByEmpId();
            //callingSp();
            // procedureWithUpdate();
            //Insertintotable();
            //AddNewDepartment();
            //GetAllDEpartment();
            //GetDepartmentByID();
            //UpdateDEptByDeptID();
            DeleteEmpByEmpId();
        }

        private static void DeleteEmpByEmpId()
        {
            var ctx = new TrainingContext();
            try
            {
                var dept = ctx.Depts.Where(d =>d.Deptno == 50).SingleOrDefault();
                ctx.Remove(dept);
                ctx.SaveChanges();
                Console.WriteLine("Removed Department Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void UpdateDEptByDeptID()
        {
            var ctx = new TrainingContext();
            try
            {
                var dept = ctx.Depts.Where(d => d.Deptno == 50).SingleOrDefault();
                dept.Loc = "Bangalore";
                ctx.SaveChanges();
                Console.WriteLine("Updated changes successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void GetDepartmentByID()
        {
            var ctx = new TrainingContext();
            try
            {
                var dept = ctx.Depts.Where(d => d.Deptno == 20).SingleOrDefault();
                Console.WriteLine(dept.Dname + " " + dept.Loc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void GetAllDEpartment()
        {
            var ctx = new TrainingContext();
            var department = ctx.Depts;
            //DbSet<Emp> employees1 = ctx.Emps;
            foreach (var dept in department)
            {
                Console.WriteLine(dept.Deptno + " " + dept.Dname + " " + dept.Loc);
            }
        }

        private static void AddNewDepartment()
        {
            var ctx = new TrainingContext();
            Dept department = new Dept();
            department.Deptno = 50;
            department.Dname = "Support";
            department.Loc = "India";

            try
            {
                ctx.Add(department);
                ctx.SaveChanges();
                Console.WriteLine("New Department Added");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }


        }

        private static void Insertintotable()
        {
            var ctx = new Models.TrainingContext();
            try {
                ctx.Database.ExecuteSqlRaw("Insertintotabl @p0 @p1 @p2 @p3 @p4 @p5 @p6 @p7", "Divya", "Trainee", 3333, 2021-11-17, 1000, 100, 10);
                Console.WriteLine("Inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }



            private static void procedureWithUpdate()
            {
                var ctx = new Models.TrainingContext();
                ctx.Database.ExecuteSqlRaw("updateEmpNameByID {0},{1}", 3333, "sheela");
                Console.WriteLine("updated");
            }


            private static void callingSp()
            {
                var ctx = new TrainingContext();
                List<Emp> emps = ctx.Set<Emp>().
                    FromSqlRaw("Getallemployees").ToList();

                foreach (var item in emps)
                {
                    Console.WriteLine(item.Ename);
                }
                //var employee = ctx.Set<Emp>().
                //    FromSqlRaw("GetEmpDetailsByEmpno @p0", 7369).ToList();



                //foreach (var item in employee)
                //{
                //    Console.WriteLine(item.Ename);
                //}
            }

            private static void DeleteEmpByEmpId()
            {
                var ctx = new TrainingContext();
                try
                {
                    var emp = ctx.Emps.Where(e => e.Empno == 3333).SingleOrDefault();
                    ctx.Remove(emp);
                    ctx.SaveChanges();
                    Console.WriteLine("Removed Employee Successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }

            private static void UpdateEmpByEmpID()
            {
                var ctx = new TrainingContext();
                try
                {
                    var emp = ctx.Emps.Where(e => e.Empno == 3333).SingleOrDefault();
                    emp.Job = "DEveloper";
                    ctx.SaveChanges();
                    Console.WriteLine("Updated changes successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }

            private static void GetEmployeeByID()
            {
                var ctx = new TrainingContext();
                try
                {
                    var emp = ctx.Emps.Where(e => e.Empno == 3333).SingleOrDefault();
                    Console.WriteLine(emp.Ename + " " + emp.Job);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }

            }

            private static void GetAllEmployee()
            {
                var ctx = new TrainingContext();
                //var employee = ctx.Emps;
                DbSet<Emp> employees1 = ctx.Emps;
                foreach (var emp in employees1)
                {
                    Console.WriteLine(emp.Empno + " " + emp.Ename + " " + emp.Sal);
                }
            }

            private static void AddNewEmployee()
            {
                var ctx = new TrainingContext();
                Emp employee = new Emp();
                employee.Empno = 3333;
                employee.Ename = "Divya";
                employee.Job = "Trainee";
                employee.Sal = 20000;
                employee.Deptno = 10;
                employee.Mgr = 7369;
                employee.Comm = 100;
                employee.Hiredate = DateTime.Now;

                try
                {
                    ctx.Add(employee);
                    ctx.SaveChanges();
                    Console.WriteLine("New employee Added");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }
            }
    }
}
