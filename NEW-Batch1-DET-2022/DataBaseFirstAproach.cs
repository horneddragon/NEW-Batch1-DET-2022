using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NEW_Batch1_DET_2022.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_Batch1_DET_2022
{
    public class DataBaseFirstAproach
    {

        static void Main()
        {
            //GetAllEmpDetails();
            ////GetDetailsById();
            //AddEmpDetails();
            //DeleteEmpDetails();
            //UpdateEmpDetails();
            //GetEmpnameWOPSp();
            //GetEmpnameWPSp();
            //AddDetailssp();
            //GetDeptSp();
            //AlterDetailssp();
            //UpdateDetails();
            CallStoredProcwithSQLParamater_insert();
        }

        //public static void GetAllEmpDetails()
        //{
        //    var ctx = new TrainingContext();
        //    var emps = ctx.Emps;
        //    foreach (var emp in emps)
        //    {
        //        Console.WriteLine(emp.Ename + " = " + emp.Sal);
        //    }
        //  public static void GetDetailsById()
        //{


        //    //var ctx = new TrainingContext();
        //    //var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    //Console.WriteLine(emp.Ename + "  " + emp.Sal  + "  "  + emp.Job
        //    //    );




        //}

        //public static void AddEmpDetails()
        //{
        //    try
        //    {
        //        var ctx = new TrainingContext();
        //        Emp employee = new Emp();
        //        employee.Empno = 2979;
        //        employee.Ename = "Sheela";
        //        employee.Sal = 1000;
        //        employee.Deptno = 30;
        //        employee.Job = "Trainer";
        //        ctx.Add(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New Employee Added");
        //    }
        //    catch (Exception e)
        //    {

        //        Console.WriteLine(e.InnerException.Message);
        //    }



        //}

        //delete
        //public static void DeleteEmpDetails()
        //{
        //    var ctx = new TrainingContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7521).SingleOrDefault();
        //    ctx.Remove(emp);
        //    ctx.SaveChanges();
        //}

        //public static void UpdateEmpDetails()
        //{
        //    var ctx = new TrainingContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 2979).SingleOrDefault();

        //    emp.Ename = "Ani";
        //    ctx.Update(emp);
        //    ctx.SaveChanges();
        //}


        //W/O Parameter
        //public static void GetEmpnameWOPSp()
        //{
        //    var ctx = new TrainingContext();
        //    var emp = ctx.Emps.FromSqlRaw($"GetEmpDetails").ToList();

        //    foreach (var item in emp)
        //    {
        //        Console.WriteLine(item.Ename);
        //    }
        //}


        //With Parameter
        //public static void GetEmpnameWPSp()
        //{
        //    var ctx = new TrainingContext();
        //    var emp = ctx.Emps.FromSqlRaw("spGetDetails @p0", 7521).ToList();

        //    foreach (var item in emp)
        //    {
        //        Console.WriteLine(item.Ename);
        //    }
        //}


        //Update
        //public static void UpdateDetails()
        //{

        //    var ctx = new TrainingContext();
        //    var Emp = ctx.Database.ExecuteSqlRaw("UPDATENAME @p0 @p1", 7566, "Anirudha");
        //    Console.WriteLine(Emp);
        //}

        //Add Details
        //public static void AddDetailssp()
        //{
        //    var ctx = new TrainingContext();
        //    var emp = ctx.Emps.FromSqlRaw($"SPADDDETAILS @p0 @p1", 3000, "Megha").ToList();
        //    ctx.Add(emp);
        //    ctx.SaveChanges();
        //}



        ////}
        //public static void GetDeptSp()
        //{
        //    var ctx = new TrainingContext();
        //    var Emp = ctx.Emps.FromSqlRaw("spGetDept ").ToList();

        //    foreach (var item in Emp)
        //    {
        //        Console.WriteLine(item);

        //    }
        //}

        //public static void AlterDetailssp()
        //{
        //    var ctx = new TrainingContext();
        //    var emp = ctx.Emps.FromSqlRaw($"spALTERDetails @p0 @p1 @p2 @p3 @p4 @p5 @p6 @p7", 2979, "Meghana", "Clerk", null, null, 2000, 1000, 5).ToList();

        //    foreach (var item in emp)
        //    {
        //        Console.WriteLine(item.Ename);

        //    }
        //}


        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new TrainingContext();
            var param = new SqlParameter[] {
            new SqlParameter() {
            ParameterName = "@EMPID",
            SqlDbType = System.Data.SqlDbType.Int,
            Size = 100,
            Direction = System.Data.
            ParameterDirection.Input,
            Value = 0001
               },

            new SqlParameter() {
            ParameterName = "@ENAME",
            SqlDbType = System.Data.
            SqlDbType.VarChar,
            Size = 100,
            Direction = System.Data.
            ParameterDirection.Input,
            Value = "VAP"},

             new SqlParameter() {
            ParameterName = "@JOB",
            SqlDbType = System.Data.
            SqlDbType.VarChar,
            Size = 100,
            Direction = System.Data.
            ParameterDirection.Input,
            Value = "SALESMAN"},

              new SqlParameter() {
            ParameterName = "@MGR",
            SqlDbType = System.Data.
            SqlDbType.Int,
            Size = 100,
            Direction = System.Data.
            ParameterDirection.Input,
            Value = 0101},

               new SqlParameter() {
            ParameterName = "@HIREDATE",
            SqlDbType = System.Data.
            SqlDbType.Date,
            Size = 100,
            Direction = System.Data.
            ParameterDirection.Input,
            Value = "1981-11-17"},

            new SqlParameter() {
            ParameterName = "@Sal",
            SqlDbType = System.Data.
            SqlDbType.Int,
            Size = 100,
            Direction = System.Data.
            ParameterDirection.Input,
            Value = 28838},

            new SqlParameter() {
            ParameterName = "@Comm",
            SqlDbType = System.Data.
            SqlDbType.Int,
            Size = 100,
            Direction = System.Data.
            ParameterDirection.Input,
            Value = null},

                  new SqlParameter() {
            ParameterName = "@DeptNo",
            SqlDbType = System.Data.
            SqlDbType.Int,
            Size = 100,
            Direction = System.Data.
            ParameterDirection.Input,
            Value = 10}
            };


            try
            {
                var result = ctx.Database.ExecuteSqlRaw("SPADDDETAILS @EMPID, @ENAME, @JOB, @MGR, @HIREDATE, @SAL, @COMM, @DEPTNO", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }

            Console.WriteLine("update successful");

        }
    }
}
            
        
    