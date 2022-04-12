using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Model.Enums;

namespace Gas_Station.EF.Configuration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.CustomerID).IsRequired();
            builder.Property(transaction => transaction.EmployeeID).IsRequired();
            builder.Property(transaction => transaction.TotalValue).HasPrecision(18, 3);
            builder.Property(transaction => transaction.PaymentMethod).HasConversion(paymentMethod => paymentMethod.ToString(),
                            paymentMethod => (PayMentMethod)Enum.Parse(typeof(PayMentMethod), paymentMethod)).HasMaxLength(15);
           
            builder.HasMany(item => item.TransactionLines)
                .WithOne(transactionLine => transactionLine.Transaction)
                .HasForeignKey(transactionLine => transactionLine.TransactionID);
        }
    }
}
