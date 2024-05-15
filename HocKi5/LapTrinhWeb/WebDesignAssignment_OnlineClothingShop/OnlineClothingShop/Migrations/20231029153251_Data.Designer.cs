﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineClothingShop.Models;

#nullable disable

namespace OnlineClothingShop.Migrations
{
    [DbContext(typeof(OnlineClothingShopContext))]
    [Migration("20231029153251_Data")]
    partial class Data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineClothingShop.Models.TbCategory", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CatID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatId"), 1L, 1);

                    b.Property<string>("CatName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Thumb")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("CatId");

                    b.ToTable("tb_Categories", (string)null);
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbCustomer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Avatar")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("District")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nchar(150)")
                        .IsFixedLength();

                    b.Property<string>("FullName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("LocationID");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Salt")
                        .HasMaxLength(8)
                        .HasColumnType("nchar(8)")
                        .IsFixedLength();

                    b.Property<int?>("Ward")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("tb_Customers", (string)null);
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbLocation", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("LocationID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<int?>("Levels")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NameWithType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ParentCode")
                        .HasColumnType("int");

                    b.Property<string>("PathWithType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Slug")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("LocationId");

                    b.ToTable("tb_Locations", (string)null);
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("CustomerID");

                    b.Property<bool?>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Paid")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int")
                        .HasColumnName("PaymentID");

                    b.Property<DateTime?>("ShipDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("TransactStatusId")
                        .HasColumnType("int")
                        .HasColumnName("TransactStatusID");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TransactStatusId");

                    b.ToTable("tb_Orders", (string)null);
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbOrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OrderDetailID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderDetailId"), 1L, 1);

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("OrderID");

                    b.Property<int?>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShipDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("tb_OrderDetails", (string)null);
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<bool?>("BestSellers")
                        .HasColumnType("bit");

                    b.Property<int?>("CatId")
                        .HasColumnType("int")
                        .HasColumnName("CatID");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime");

                    b.Property<string>("DescImg")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<bool?>("HomeFlag")
                        .HasColumnType("bit");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ShortDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SingleImg")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ThumbImg")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("ProductId")
                        .HasName("PK_tb_Products_1");

                    b.HasIndex("CatId");

                    b.ToTable("tb_Products", (string)null);
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbTransactStatus", b =>
                {
                    b.Property<int>("TransactStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TransactStatusID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactStatusId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TransactStatusId");

                    b.ToTable("tb_TransactStatus", (string)null);
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbCustomer", b =>
                {
                    b.HasOne("OnlineClothingShop.Models.TbLocation", "Location")
                        .WithMany("TbCustomers")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK_tb_Customers_tb_Locations");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbOrder", b =>
                {
                    b.HasOne("OnlineClothingShop.Models.TbCustomer", "Customer")
                        .WithMany("TbOrders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_tb_Orders_tb_Customers");

                    b.HasOne("OnlineClothingShop.Models.TbTransactStatus", "TransactStatus")
                        .WithMany("TbOrders")
                        .HasForeignKey("TransactStatusId")
                        .HasConstraintName("FK_tb_Orders_tb_TransactStatus");

                    b.Navigation("Customer");

                    b.Navigation("TransactStatus");
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbOrderDetail", b =>
                {
                    b.HasOne("OnlineClothingShop.Models.TbOrder", "Order")
                        .WithMany("TbOrderDetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_tb_OrderDetails_tb_Orders");

                    b.HasOne("OnlineClothingShop.Models.TbProduct", "Product")
                        .WithMany("TbOrderDetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_tb_OrderDetails_tb_Products");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbProduct", b =>
                {
                    b.HasOne("OnlineClothingShop.Models.TbCategory", "Cat")
                        .WithMany("TbProducts")
                        .HasForeignKey("CatId")
                        .HasConstraintName("FK_tb_Products_tb_Categories");

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbCategory", b =>
                {
                    b.Navigation("TbProducts");
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbCustomer", b =>
                {
                    b.Navigation("TbOrders");
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbLocation", b =>
                {
                    b.Navigation("TbCustomers");
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbOrder", b =>
                {
                    b.Navigation("TbOrderDetails");
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbProduct", b =>
                {
                    b.Navigation("TbOrderDetails");
                });

            modelBuilder.Entity("OnlineClothingShop.Models.TbTransactStatus", b =>
                {
                    b.Navigation("TbOrders");
                });
#pragma warning restore 612, 618
        }
    }
}