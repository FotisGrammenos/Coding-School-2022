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
    internal class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Name).HasMaxLength(100);
            builder.Property(c => c.Surname).HasMaxLength(100);
            builder.Property(c => c.TIN).HasMaxLength(20);
            builder.Property(c => c.Phone).HasMaxLength(20);
        }
    }
}
