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
    internal class TransactionLInesConfig : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.Property(tl => tl.EngineerID).IsRequired();
            builder.Property(tl => tl.ServiceTaskID).IsRequired();

           
        }
    }
}
