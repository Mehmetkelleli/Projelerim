// <auto-generated />
using System;
using Fashion.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fashion.Data.Migrations
{
    [DbContext(typeof(ShopDataContext))]
    [Migration("20220817053717_Added cartItems")]
    partial class AddedcartItems
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Fashion.entity.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Fashion.entity.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Fashion.entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Fashion.entity.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ColorCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Fashion.entity.HomePageSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ButtonTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ButtonUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HomePageSliders");
                });

            modelBuilder.Entity("Fashion.entity.MainCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("clicsk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MainCategories");
                });

            modelBuilder.Entity("Fashion.entity.Pictures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("Fashion.entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("Click")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsHome")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Fashion.entity.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("Fashion.entity.ProductSize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductSizes");
                });

            modelBuilder.Entity("Fashion.entity.SiteConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SiteClick")
                        .HasColumnType("int");

                    b.Property<string>("Smtp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmtpPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SmtpPort")
                        .HasColumnType("int");

                    b.Property<string>("SmtpUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SiteConfig");
                });

            modelBuilder.Entity("Fashion.entity.CartItem", b =>
                {
                    b.HasOne("Fashion.entity.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fashion.entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Fashion.entity.Category", b =>
                {
                    b.HasOne("Fashion.entity.MainCategory", "MainCategory")
                        .WithMany("Categories")
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCategory");
                });

            modelBuilder.Entity("Fashion.entity.Pictures", b =>
                {
                    b.HasOne("Fashion.entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Fashion.entity.Product", b =>
                {
                    b.HasOne("Fashion.entity.Color", "Color")
                        .WithMany("Product")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Color");
                });

            modelBuilder.Entity("Fashion.entity.ProductCategory", b =>
                {
                    b.HasOne("Fashion.entity.Category", "Category")
                        .WithMany("ProductCategory")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fashion.entity.Product", "Product")
                        .WithMany("ProductCategory")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Fashion.entity.ProductSize", b =>
                {
                    b.HasOne("Fashion.entity.Product", "Product")
                        .WithMany("ProductSize")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Fashion.entity.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("Fashion.entity.Category", b =>
                {
                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("Fashion.entity.Color", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Fashion.entity.MainCategory", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Fashion.entity.Product", b =>
                {
                    b.Navigation("ProductCategory");

                    b.Navigation("ProductSize");
                });
#pragma warning restore 612, 618
        }
    }
}
