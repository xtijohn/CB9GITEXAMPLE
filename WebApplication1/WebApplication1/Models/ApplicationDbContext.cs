using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ApplicationDbContext : DbContext
    {
        #region DbSets
        public DbSet<Student> Students { get; set; }
        #endregion

        #region Constructors
        public ApplicationDbContext() : base("SampleConnection")
        {

        }
        #endregion

    }
}