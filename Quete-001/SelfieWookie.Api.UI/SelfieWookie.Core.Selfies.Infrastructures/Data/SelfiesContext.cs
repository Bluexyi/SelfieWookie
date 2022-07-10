using Microsoft.EntityFrameworkCore;
using SelfieWookie.Core.Selfies.Domain;
using SelfieWookie.Core.Selfies.Infrastructures.Data.TypeConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieWookie.Core.Selfies.Infrastructures.Data
{
    public class SelfiesContext : DbContext
    {

        #region Internal methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SelfieEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WookieEntityTypeConfiguration());
        }
        #endregion

        #region Properties
        public DbSet<Selfie> Selfies { get; set; }

        public DbSet<Wookie> Wookies { get; set; }   
        #endregion
    }
}
