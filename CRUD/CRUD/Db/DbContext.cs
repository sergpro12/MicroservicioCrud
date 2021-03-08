using CRUD.Db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Db
{
    public class DBContext : DbContext 
    {

        public DbSet<User>Users{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"data source =LAPTOP-AD9778AO; initial catalog =Microservice; user id =sa; password =progra;");
        }

    }
}
