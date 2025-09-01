using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VTS.Domain.Entities;

namespace VTS.Data
{
    public class VTSContext : IdentityDbContext<User>
    {
        #region Constructor
        public VTSContext(DbContextOptions<VTSContext> options) : base(options)
        {
        }
        #endregion

        #region DbSets
        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        #endregion

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional configuration can go here
        }
        #endregion
    }
}
