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
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Items");
            builder.HasKey(item=>item.ID);
            builder.Property(item=>item.Cost).HasMaxLength(100);
            builder.HasIndex(item => item.Code).IsUnique();
            builder.Property(item => item.Type).HasConversion(itemType => itemType.ToString(),
                            itemType => (ItemType)Enum.Parse(typeof(ItemType), itemType)).HasMaxLength(15);
            builder.Property(item=> item.Description).HasMaxLength(100);
            builder.Property(item=> item.Price).HasPrecision(10, 3);
            builder.Property(item=> item.Cost).HasPrecision(10, 3);

           
            builder.HasMany(item =>item.TransactionLines)
                .WithOne(transactionLine => transactionLine.Item)
                .HasForeignKey(transactionLine => transactionLine.ItemID);
        }
    }
}
