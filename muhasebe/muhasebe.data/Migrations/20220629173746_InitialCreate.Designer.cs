﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using muhasebe.data.Concrete;

namespace muhasebe.data.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20220629173746_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("muhasebe.entity.EntityClass.Process", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Acıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kayıp")
                        .HasColumnType("int");

                    b.Property<int>("Kazanc")
                        .HasColumnType("int");

                    b.Property<int>("ProcessCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessCategoryId");

                    b.ToTable("Process");
                });

            modelBuilder.Entity("muhasebe.entity.EntityClass.ProcessCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProcessCategories");
                });

            modelBuilder.Entity("muhasebe.entity.EntityClass.Process", b =>
                {
                    b.HasOne("muhasebe.entity.EntityClass.ProcessCategory", "ProcessCategory")
                        .WithMany("Process")
                        .HasForeignKey("ProcessCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProcessCategory");
                });

            modelBuilder.Entity("muhasebe.entity.EntityClass.ProcessCategory", b =>
                {
                    b.Navigation("Process");
                });
#pragma warning restore 612, 618
        }
    }
}
