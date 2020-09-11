﻿// <auto-generated />
using System;
using MicroS.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroS.Infrastructure.Migrations
{
    [DbContext(typeof(MicroSDBContext))]
    [Migration("20200908122305_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MicroS.Infrastructure.DataAccess.Contracts.Entities.ComunaEntity", b =>
                {
                    b.Property<int>("IdReg")
                        .HasColumnType("int");

                    b.Property<int>("IdCom")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdReg");

                    b.ToTable("Comuna");
                });

            modelBuilder.Entity("MicroS.Infrastructure.DataAccess.Contracts.Entities.RegionEntity", b =>
                {
                    b.Property<int>("IdReg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdReg");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("MicroS.Infrastructure.DataAccess.Contracts.Entities.User2ComunaEntity", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("IdCom")
                        .HasColumnType("int");

                    b.HasKey("IdUser", "IdCom");

                    b.HasIndex("IdCom");

                    b.ToTable("User2Comuna");
                });

            modelBuilder.Entity("MicroS.Infrastructure.DataAccess.Contracts.Entities.UserEntity", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Actiive")
                        .HasColumnType("bit");

                    b.Property<string>("ApellidoP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rut")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MicroS.Infrastructure.DataAccess.Contracts.Entities.ComunaEntity", b =>
                {
                    b.HasOne("MicroS.Infrastructure.DataAccess.Contracts.Entities.RegionEntity", "Region")
                        .WithMany("Comuna")
                        .HasForeignKey("IdReg")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MicroS.Infrastructure.DataAccess.Contracts.Entities.User2ComunaEntity", b =>
                {
                    b.HasOne("MicroS.Infrastructure.DataAccess.Contracts.Entities.ComunaEntity", "Comuna")
                        .WithMany("User2Comuna")
                        .HasForeignKey("IdCom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MicroS.Infrastructure.DataAccess.Contracts.Entities.UserEntity", "User")
                        .WithMany("User2Comuna")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}