using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Station.EF.Configuration
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.ToTable("TransactionLines");
            builder.HasKey(transactionLine => transactionLine.ID);
            builder.Property(transactionLine => transactionLine.TransactionID).IsRequired();
            builder.Property(transactionLine => transactionLine.ItemID).IsRequired();
            builder.Property(transactionLine => transactionLine.Quantity).HasPrecision(9, 3);
            builder.Property(transactionLine => transactionLine.ItemPrice).HasPrecision(9, 3);
            builder.Property(transactionLine => transactionLine.NetValue).HasPrecision(9, 3);
            builder.Property(transactionLine => transactionLine.DiscountPercent).HasPrecision(9, 3);
            builder.Property(transactionLine => transactionLine.TotalValue).HasPrecision(9, 3);
            builder.Property(transactionLine => transactionLine.TotalValue).HasPrecision(9, 3);
           
        }
    }
}
