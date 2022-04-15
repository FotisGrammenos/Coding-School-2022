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
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(user => user.ID);
            builder.Property(user => user.ID).ValueGeneratedOnAdd();

            builder.HasIndex(user => user.Username).IsUnique();
            builder.Property(user => user.Role).HasConversion(role => role.ToString(), role => (EmployeeType)Enum.Parse(typeof(EmployeeType), role));
        }
    }
}
