using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataLibrary.DataClasses;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.EF.Configs
{
    internal class CredentialConfig : IEntityTypeConfiguration<Credential>
    {
        public void Configure(EntityTypeBuilder<Credential> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.Username).HasMaxLength(100);
            builder.Property(c => c.Password).HasColumnType("decimal(18,4)"); 
        }
    }
}
