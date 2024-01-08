using Microsoft.EntityFrameworkCore;
using TPT_Demo.Models.SharedTables;

namespace TPT_Demo.Models.Context
{
    public class ContextDataBase : DbContext
    {
        public ContextDataBase(DbContextOptions<ContextDataBase> options) : base(options)
        {
        }

        public DbSet<BaseEntity> BaseEntities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BaseEntity>()
            //.ToTable("BaseEntities") // Common table for properties in BaseEntity
            //.HasDiscriminator<string>("EntityType")
            //.HasValue<Table1>("Table1")
            //.HasValue<Table2>("Table2")
            //.HasValue<Table3>("Table3");

            //modelBuilder.Entity<Table1>().ToTable("Table1");
            //modelBuilder.Entity<Table2>().ToTable("Table2");
            //modelBuilder.Entity<Table3>().ToTable("Table3");

            modelBuilder.Entity<BaseEntity>().ToTable("BaseEntities");
            modelBuilder.Entity<Table1>().ToTable("Table1");
            modelBuilder.Entity<Table2>().ToTable("Table2");
            modelBuilder.Entity<Table3>().ToTable("Table3");
        }



    }
}
