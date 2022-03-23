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
    internal class ManagerConfig : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.Property(m => m.Name).HasMaxLength(100);
            builder.Property(m => m.Surname).HasMaxLength(100);
            builder.Property(m => m.SallaryPerMonth).HasColumnType("decimal(18,4)"); 
           
        }
    }
}
