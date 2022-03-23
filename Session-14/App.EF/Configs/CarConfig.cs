using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataLibrary;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.EF.Configs
{
    internal class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.Brand).HasMaxLength(50);
            builder.Property(c => c.CarRegNumber).HasMaxLength(50);
            builder.Property(c => c.Model).HasMaxLength(10);
        }
    }
}
