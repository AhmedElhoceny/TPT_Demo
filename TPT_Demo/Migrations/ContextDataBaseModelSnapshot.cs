﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPT_Demo.Models.Context;

#nullable disable

namespace TPT_Demo.Migrations
{
    [DbContext(typeof(ContextDataBase))]
    partial class ContextDataBaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TPT_Demo.Models.BaseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("BaseEntities", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("TPT_Demo.Models.SharedTables.Table1", b =>
                {
                    b.HasBaseType("TPT_Demo.Models.BaseEntity");

                    b.Property<string>("PropertyForTable1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Table1", (string)null);
                });

            modelBuilder.Entity("TPT_Demo.Models.SharedTables.Table2", b =>
                {
                    b.HasBaseType("TPT_Demo.Models.BaseEntity");

                    b.Property<string>("PropertyForTable2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Table2", (string)null);
                });

            modelBuilder.Entity("TPT_Demo.Models.SharedTables.Table3", b =>
                {
                    b.HasBaseType("TPT_Demo.Models.BaseEntity");

                    b.Property<string>("PropertyForTable3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Table3", (string)null);
                });

            modelBuilder.Entity("TPT_Demo.Models.SharedTables.Table1", b =>
                {
                    b.HasOne("TPT_Demo.Models.BaseEntity", null)
                        .WithOne()
                        .HasForeignKey("TPT_Demo.Models.SharedTables.Table1", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TPT_Demo.Models.SharedTables.Table2", b =>
                {
                    b.HasOne("TPT_Demo.Models.BaseEntity", null)
                        .WithOne()
                        .HasForeignKey("TPT_Demo.Models.SharedTables.Table2", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TPT_Demo.Models.SharedTables.Table3", b =>
                {
                    b.HasOne("TPT_Demo.Models.BaseEntity", null)
                        .WithOne()
                        .HasForeignKey("TPT_Demo.Models.SharedTables.Table3", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
