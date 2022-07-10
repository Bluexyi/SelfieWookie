using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SelfieWookie.Core.Selfies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieWookie.Core.Selfies.Infrastructures.Data.TypeConfigurations
{
    class WookieEntityTypeConfiguration : IEntityTypeConfiguration<Selfie>
    {

        #region Public methods
        public void Configure(EntityTypeBuilder<Selfie> builder)
        {
            builder.ToTable("Wookie");
        }
        #endregion
    }
}
