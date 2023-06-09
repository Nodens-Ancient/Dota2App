﻿// <auto-generated />
using System;
using Dota2App.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dota2App.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230317203833_RemoovedNullableID")]
    partial class RemoovedNullableID
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dota2App.Models.HeroModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("AgilityGain")
                        .HasColumnType("float");

                    b.Property<int>("AttackRange")
                        .HasColumnType("int");

                    b.Property<float>("AttackSpeed")
                        .HasColumnType("float");

                    b.Property<int>("BaseAgility")
                        .HasColumnType("int");

                    b.Property<float>("BaseArmor")
                        .HasColumnType("float");

                    b.Property<int>("BaseAttackDamageMax")
                        .HasColumnType("int");

                    b.Property<int>("BaseAttackDamageMin")
                        .HasColumnType("int");

                    b.Property<int>("BaseHealth")
                        .HasColumnType("int");

                    b.Property<float>("BaseHealthRegen")
                        .HasColumnType("float");

                    b.Property<int>("BaseIntellect")
                        .HasColumnType("int");

                    b.Property<int>("BaseMagicResist")
                        .HasColumnType("int");

                    b.Property<int>("BaseMana")
                        .HasColumnType("int");

                    b.Property<float>("BaseManaRegen")
                        .HasColumnType("float");

                    b.Property<int>("BaseStrength")
                        .HasColumnType("int");

                    b.Property<float>("IntellectGain")
                        .HasColumnType("float");

                    b.Property<string>("MainAttribute")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MoveSpeed")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProjectileSpeed")
                        .HasColumnType("int");

                    b.Property<float>("StrengthGain")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("Dota2App.Models.ItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
