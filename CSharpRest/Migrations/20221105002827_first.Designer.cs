﻿// <auto-generated />
using CSharpRest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSharpRest.Migrations
{
    [DbContext(typeof(DestinoDBContext))]
    [Migration("20221105002827_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CSharpRest.Models.Destino", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("varchar(70)")
                        .HasMaxLength(70);

                    b.HasKey("ID");

                    b.ToTable("destino");
                });
#pragma warning restore 612, 618
        }
    }
}
