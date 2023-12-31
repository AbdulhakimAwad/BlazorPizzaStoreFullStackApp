﻿// <auto-generated />
using LearnBlazor.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearnBlazor.Server.Migrations
{
    [DbContext(typeof(AppDbCtx))]
    partial class AppDbCtxModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LearnBlazor.Shared.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PizzaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Pizza");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImgUrl = "Images/mushroomjpg.jpeg",
                            PizzaName = "Mushroom",
                            Price = 20m
                        },
                        new
                        {
                            Id = 2,
                            ImgUrl = "Images/carbonara.jpg",
                            PizzaName = "Carbonara",
                            Price = 22.72m
                        },
                        new
                        {
                            Id = 3,
                            ImgUrl = "Images/seafood.jpg",
                            PizzaName = "Seafood",
                            Price = 37.40m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
