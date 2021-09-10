﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistrarRolesWpf.DAL;

namespace RegistrarRolesWpf.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20210909015040_RolesInicial")]
    partial class RolesInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("RegistrarRolesWpf.ENTIDADES.rRoles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.HasKey("RolId");

                    b.ToTable("roles");
                });
#pragma warning restore 612, 618
        }
    }
}
