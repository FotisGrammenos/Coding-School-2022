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
    internal class ServiceTaskConfig : IEntityTypeConfiguration<ServiceTask>
    {
        public void Configure(EntityTypeBuilder<ServiceTask> builder)
        {
            builder.Property(s => s.Code).HasMaxLength(100);
            builder.Property(s => s.Hours).HasColumnType("decimal(18,4)"); 
            builder.Property(s => s.Description).HasMaxLength(100);
            
        }
    }
}
