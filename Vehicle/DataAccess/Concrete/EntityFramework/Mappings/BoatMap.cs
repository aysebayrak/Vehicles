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
    public class BoatMap : IEntityTypeConfiguration<Boat>
    {
        public void Configure(EntityTypeBuilder<Boat> builder)
        {
            builder.ToTable("Boats");
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Id).UseIdentityColumn();
            builder.Property(v => v.CreatedDate).IsRequired().HasColumnName("datatime");
            builder.Property(v => v.UpdatedDate).HasColumnName("datatime");
            builder.Property(x => x.Color).IsRequired().HasColumnType("nvarchar(MAX)");

        }
    }
}
