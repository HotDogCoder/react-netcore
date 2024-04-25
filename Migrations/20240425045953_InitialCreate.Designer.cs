﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using time_of_your_life.Infrastructure.Contexts;

#nullable disable

namespace time_of_your_life.Migrations
{
    [DbContext(typeof(SqlLiteContext))]
    [Migration("20240425045953_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("time_of_your_life.Domain.Entities.Preset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("BlinkColons")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClockFontSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FontColor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FontFamily")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TitleFontSize")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Presets");
                });
#pragma warning restore 612, 618
        }
    }
}
