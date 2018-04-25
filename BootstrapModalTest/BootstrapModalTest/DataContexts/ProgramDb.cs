using BootstrapModalTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BootstrapModalTest.DataContexts
{
    public class ProgramDb: DbContext
    {
       
        public ProgramDb(): base("DefaultConnection")
        {
        }

        public DbSet<Person> People { get; set; }
    }
}