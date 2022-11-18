using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mapping işlemi bizim veritabanına gidecek olan nesnelerimizin ayarlarını ve özelliklerini belirttiğimiz bölümdür.
//using Microsoft.EntityFrameworkCore.Metadata.Builders; : import edilmeli.

// Mapiing den sonra context de ovveride  metod olan OnModelCreating  metodunu çağırıyoruz ve
// ApplyConfiguration  metodunu kullanarak  tanımlama işlemini gerçekleştiryoruz.



namespace DataAccess.Concrete.EntityFramework.Mappings
{
      public class BusMap :IEntityTypeConfiguration<Bus>
    {
        public void Configure(EntityTypeBuilder<Bus> builder)
        {
            builder.ToTable("Buses"); //Tablo adı
            builder.HasKey(v => v.Id); // Primay key yapar
            builder.Property(v => v.Id).UseIdentityColumn();
            builder.Property(v => v.CreatedDate).IsRequired().HasColumnType("datetime");
            builder.Property(v => v.UpdatedDate).HasColumnType("datetime");

            builder.Property(v => v.Color).IsRequired().HasColumnType("nvarchar(MAX)");

            //IsRequired() -> Bu alanın boş geçilemez 
            //IsUnique()->Bu metot ise ilgili alanın veritabanında tek yani unique bir şekilde olması gerektiğini belirtir
            //HasColumnType() -> Bu metot ilgili alanın veritabanın da hangi alana karşılık geleceği ve kaç karakter alacağını belirtir.
            //UseIdentityColumn() : bir bir  artan kolon

        }
    }
}
 