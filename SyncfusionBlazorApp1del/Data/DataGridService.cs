using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SyncfusionBlazorApp1del.Model;

namespace SyncfusionBlazorApp1del.Data
{
   public class DataGridService
   {
         SynfusionDbContext db=new SynfusionDbContext();
		 
        //To Get all Employee details   
        public DbSet<Employee> GetAllEmployee()
        {
            try
            {
                return db.Employees;
            }
            catch
            {
                throw;
            }
        }
       // To Add new Data record
        public void AddEmployee(Employee Data)
        {
            try
            {
                db.Employees.Add(Data);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Data    
         public void UpdateEmployee(Employee Data)
        {
            try
            {
                var data = db.Employees.Where(x => x.EmployeeId == Data.EmployeeId).SingleOrDefault();
                data.EmployeeId=Data.EmployeeId;
                data.Name=Data.Name;
                data.City=Data.City;
                data.Department=Data.Department;
                data.Gender=Data.Gender;
		   
			  
               db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Data
         public void DeleteEmployee(int value)
         {
           try
           {
             Employee data = db.Employees.Find(value);
            db.Employees.Remove(data);
            db.SaveChanges();
           }
           catch
           {
             throw;
            }
          }

        //Get the details of a particular Data    
        public Employee GetEmployeeData(int id)
        {
            try
            {
                Employee Data = db.Employees.Find(id);
                return Data;
            }
            catch
            {
                throw;
            }
        }
    }
   
}