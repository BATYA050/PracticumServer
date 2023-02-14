using Microsoft.EntityFrameworkCore;
using MyProjectR_B.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using MyProjectR_B.Repositories.Entities;


namespace MyProjectR_B.Context
{
    public class DataContext:DbContext,IContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Children> Children { get; set; }
    


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
           "Server=(localdb)\\mssqllocaldb;Database=MyProjectDB;Trusted_Connection=True;");
        }




    }
}
