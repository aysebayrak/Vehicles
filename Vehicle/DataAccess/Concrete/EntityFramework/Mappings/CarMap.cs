using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {

            builder.ToTable("Cars");
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Id).UseIdentityColumn();
            builder.Property(v => v.CreatedDate).IsRequired().HasColumnType("datetime");
            builder.Property(v => v.UpdatedDate).HasColumnType("datetime");
            builder.Property(v => v.Color).IsRequired().HasColumnType("nvarchar(MAX)");
            builder.Property(v => v.Whells).IsRequired();
            builder.Property(v => v.Headlights).IsRequired();



        }

    }
}
