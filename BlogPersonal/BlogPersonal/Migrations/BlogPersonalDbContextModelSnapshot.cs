﻿// <auto-generated />
using BlogPersonal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BlogPersonal.Migrations
{
    [DbContext(typeof(BlogPersonalDbContext))]
    partial class BlogPersonalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogPersonal.Models.Publicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Autor");

                    b.Property<string>("Cuerpo");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Foto");

                    b.Property<string>("Subtitulo");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Publicacion");
                });
#pragma warning restore 612, 618
        }
    }
}
