using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

// Application AB Context is a giant classs that is allow you to search your individual tables
namespace api.Data
{
    // first we need to inherit from DB context
    public class ApplicationABContexts : DbContext
    {
        // ctor and tab to add the constructor below
        // :base(dbContextOptions) is using :base to pass the dbContextOptions into DbContext on the Public Class
        // DbContext will come in here, then find your tables, and creates the Database for you

        public ApplicationABContexts(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }
        //DBset is like saying "I gonna wrap something from the database and you need to do something with it. 
        // It is going to return the data in whatever form that you want 
        // Note: Remember whenever you use DbSet you are manipulating the whole entire table
        // In this case: We are manipulating the whole entire Stock table
        // And this will create the database for us

        public DbSet<Stocks> Stocks {get; set;}
        public DbSet<Comment> Comments {get; set;}




    }

}
