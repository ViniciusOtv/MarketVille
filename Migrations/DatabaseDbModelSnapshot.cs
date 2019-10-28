﻿// <auto-generated />
using System;
using MarktVille.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarktVille.Migrations
{
    [DbContext(typeof(DatabaseDb))]
    partial class DatabaseDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MarktVille.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MarktVille.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("ImageLocality");

                    b.Property<string>("NickName");

                    b.Property<string>("Street");

                    b.Property<string>("UF");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MarktVille.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriyId");

                    b.Property<string>("Color");

                    b.Property<int?>("CostPrice");

                    b.Property<string>("Details");

                    b.Property<string>("Image");

                    b.Property<string>("LargeImage");

                    b.Property<string>("MediumImage");

                    b.Property<string>("Name");

                    b.Property<int>("SellingPrice");

                    b.Property<string>("ShortDescription");

                    b.Property<string>("Size");

                    b.Property<string>("SmallImage");

                    b.Property<int>("StoreId");

                    b.Property<int>("SubCategoryId");

                    b.Property<int?>("SupplierId");

                    b.Property<int?>("Voltage");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MarktVille.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoverImage");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<int>("LocationId");

                    b.Property<string>("Name");

                    b.Property<int>("SupplierId");

                    b.HasKey("StoreId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("MarktVille.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("SubCategoryId");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("MarktVille.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("LocationId");

                    b.Property<string>("Name");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });
#pragma warning restore 612, 618
        }
    }
}
