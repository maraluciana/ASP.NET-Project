﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectFlowerShop.DAL;

namespace ProjectFlowerShop.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20230129172620_Test3")]
    partial class Test3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectFlowerShop.DAL.Entities.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.Property<string>("codeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("discountType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("ProjectFlowerShop.DAL.Entities.Letter", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Letters");
                });

            modelBuilder.Entity("ProjectFlowerShop.DAL.Entities.ProductCart", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CartId");

                    b.HasIndex("CartId");

                    b.ToTable("ProductCart");
                });

            modelBuilder.Entity("ProjectFlowerShop.DAL.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("productType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ProjectFlowerShop.DAL.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<float>("totalPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("DiscountId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("ProjectFlowerShop.DAL.Entities.Letter", b =>
                {
                    b.HasOne("ProjectFlowerShop.DAL.ShoppingCart", "ShoppingCart")
                        .WithOne("Letter")
                        .HasForeignKey("ProjectFlowerShop.DAL.Entities.Letter", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("ProjectFlowerShop.DAL.Entities.ProductCart", b =>
                {
                    b.HasOne("ProjectFlowerShop.DAL.ShoppingCart", "ShoppingCart")
                        .WithMany("ProductCarts")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjectFlowerShop.DAL.Product", "Product")
                        .WithMany("ProductCarts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("ProjectFlowerShop.DAL.ShoppingCart", b =>
                {
                    b.HasOne("ProjectFlowerShop.DAL.Entities.Discount", "Discount")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discount");
                });

            modelBuilder.Entity("ProjectFlowerShop.DAL.Entities.Discount", b =>
                {
                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("ProjectFlowerShop.DAL.Product", b =>
                {
                    b.Navigation("ProductCarts");
                });

            modelBuilder.Entity("ProjectFlowerShop.DAL.ShoppingCart", b =>
                {
                    b.Navigation("Letter");

                    b.Navigation("ProductCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
