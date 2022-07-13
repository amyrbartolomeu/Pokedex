﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonApi.Data;

#nullable disable

namespace PokemonApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.5.22302.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PokemonApi.Entities.Pokedex.Pokedex", b =>
                {
                    b.Property<int>("PokedexId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PokedexId"), 1L, 1);

                    b.Property<int>("ATK")
                        .HasColumnType("int");

                    b.Property<int>("Aquireable")
                        .HasColumnType("int");

                    b.Property<int>("CP39")
                        .HasColumnType("int");

                    b.Property<int>("CP40")
                        .HasColumnType("int");

                    b.Property<bool>("CrossGen")
                        .HasColumnType("bit");

                    b.Property<int>("DEF")
                        .HasColumnType("int");

                    b.Property<string>("EvolutionStage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Evolved")
                        .HasColumnType("bit");

                    b.Property<int>("FamilyId")
                        .HasColumnType("int");

                    b.Property<bool>("FutureEvolve")
                        .HasColumnType("bit");

                    b.Property<int>("Generation")
                        .HasColumnType("int");

                    b.Property<int>("Hatchable")
                        .HasColumnType("int");

                    b.Property<string>("ImgName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Legendary")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Nest")
                        .HasColumnType("bit");

                    b.Property<bool>("New")
                        .HasColumnType("bit");

                    b.Property<bool>("NotGettable")
                        .HasColumnType("bit");

                    b.Property<int>("PokedexNumber")
                        .HasColumnType("int");

                    b.Property<int>("Raidable")
                        .HasColumnType("int");

                    b.Property<bool>("Regional")
                        .HasColumnType("bit");

                    b.Property<int>("STA")
                        .HasColumnType("int");

                    b.Property<bool>("Shiny")
                        .HasColumnType("bit");

                    b.Property<bool>("Spawns")
                        .HasColumnType("bit");

                    b.Property<int>("StatTotal")
                        .HasColumnType("int");

                    b.Property<int>("TypeOne")
                        .HasColumnType("int");

                    b.Property<int?>("TypeTwo")
                        .HasColumnType("int");

                    b.Property<int>("WeatherOne")
                        .HasColumnType("int");

                    b.Property<int?>("WeatherTwo")
                        .HasColumnType("int");

                    b.HasKey("PokedexId");

                    b.ToTable("Pokedex");
                });
#pragma warning restore 612, 618
        }
    }
}
