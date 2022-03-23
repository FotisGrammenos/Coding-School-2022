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
    internal class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(t => t.ID);
            builder.Property(t => t.ManagerID).IsRequired();
            builder.Property(t => t.CustomerID).IsRequired();
            builder.Property(t => t.CarID).IsRequired();
            builder.Property(t => t.TotalPrice).HasColumnType("decimal(18,4)");

           
        }
    }
}
