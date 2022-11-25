using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public  class Context : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-D19MH5E\\SQLEXPRESS; DataBase = EVehicleDb ;Trusted_Connection=true;Encrypt=False") ;
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Bus> Buses { get; set; }


        //mapping
        
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            

            modelBuilder.ApplyConfiguration(new CarMap());
            modelBuilder.ApplyConfiguration(new BusMap());
            modelBuilder.ApplyConfiguration(new BoatMap());


        }

    }

}
