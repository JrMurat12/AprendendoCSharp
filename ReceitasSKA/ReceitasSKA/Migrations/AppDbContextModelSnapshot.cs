﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReceitasSKA.Data;

#nullable disable

namespace ReceitasSKA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ReceitasSKA.Models.AssociacaoReceita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodigoProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoRecurso")
                        .HasColumnType("int");

                    b.Property<string>("LotePadrao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceitaId")
                        .HasColumnType("int");

                    b.Property<float>("TempoPadrao")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ReceitaId")
                        .IsUnique();

                    b.ToTable("AssociacaoReceita");
                });

            modelBuilder.Entity("ReceitasSKA.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodigoCT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoReceita")
                        .HasColumnType("int");

                    b.Property<string>("LotePadrao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TempoPadrao")
                        .HasColumnType("real");

                    b.Property<float>("VersaoPeso")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("ReceitasSKA.Models.AssociacaoReceita", b =>
                {
                    b.HasOne("ReceitasSKA.Models.Receita", "Receita")
                        .WithOne("AssociacaoReceita")
                        .HasForeignKey("ReceitasSKA.Models.AssociacaoReceita", "ReceitaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receita");
                });

            modelBuilder.Entity("ReceitasSKA.Models.Receita", b =>
                {
                    b.Navigation("AssociacaoReceita")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
