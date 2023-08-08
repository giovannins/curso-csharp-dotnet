﻿// <auto-generated />
using MetodosREST.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MetodosREST.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20230808160553_InicialCreate")]
    partial class InicialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MetodosREST.Models.Pessoa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("varchar(1)")
                        .HasColumnName("genero");

                    b.Property<int>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("idade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("sobrenome");

                    b.HasKey("Id");

                    b.ToTable("pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
