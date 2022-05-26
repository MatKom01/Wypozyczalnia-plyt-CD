﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjektMVC.Models;

namespace ProjektMVC.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20220522231007_addCDmigration")]
    partial class addCDmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjektMVC.Models.CD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Lenght")
                        .HasColumnType("int");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Premiere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Production")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Scenario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CDs");

                    b.HasData(
                        new
                        {
                            ID = 101,
                            Direction = "Anthony Russo / Joe Russo",
                            Lenght = 159,
                            Picture = "https://fwcdn.pl/fpo/37/58/693758/7839647.6.jpg",
                            Premiere = "23 kwietnia 2018 (świat)",
                            Price = 29.989999999999998,
                            Production = "USA",
                            Scenario = "Christopher Markus / Stephen McFeely",
                            Title = "Avengers: Wojna bez granic",
                            Type = "Akcja"
                        },
                        new
                        {
                            ID = 102,
                            Direction = "Bob Persichetti / Peter Ramsey / więcej...",
                            Lenght = 117,
                            Picture = "https://fwcdn.pl/fpo/32/33/743233/7866074.6.jpg",
                            Premiere = "7 grudnia 2018 (świat)",
                            Price = 29.989999999999998,
                            Production = "USA",
                            Scenario = "Phil Lord / Rodney Rothman",
                            Title = "Spider-Man Uniwersum",
                            Type = "Akcja"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
