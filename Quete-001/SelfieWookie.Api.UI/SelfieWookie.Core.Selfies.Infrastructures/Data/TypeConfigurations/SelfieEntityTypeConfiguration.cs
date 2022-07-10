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
    class SelfieEntityTypeConfiguration : IEntityTypeConfiguration<Selfie>
    {

        #region Public methods
        public void Configure(EntityTypeBuilder<Selfie> builder)
        {
            object value = builder.ToTable("Selfie");
            builder.HasKey(item => item.Id);
            builder.HasOne(item => item.Wookie)
                .WithMany(item => item.Selfies); //Un Wookie peut avoir plusieurs Selfie
        }
        #endregion
    }
}
