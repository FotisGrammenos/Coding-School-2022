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
    internal class EngineerConfig : IEntityTypeConfiguration<Engineer>
    {
        public void Configure(EntityTypeBuilder<Engineer> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e=>e.Surname).HasMaxLength(100);
            builder.Property(e => e.SallaryPerMonth).HasColumnType("decimal(18,4)"); 
            builder.Property(e=>e.Status).HasMaxLength(100);
            builder.Property(e => e.ManagerID).IsRequired();
        }
    }
}
