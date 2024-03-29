﻿// <auto-generated />
using System;
using Fiap.Aula05.Web.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiap.Aula05.Web.Migrations
{
    [DbContext(typeof(GestaoAereaContext))]
    partial class GestaoAeraContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fiap.Aula05.Web.Models.FrequenciaVoo", b =>
                {
                    b.Property<int>("FrequenciaVooId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FrequenciaVooId"), 1L, 1);

                    b.Property<int>("CodigoFrequencia")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAtivacao")
                        .HasColumnType("datetime2");

                    b.HasKey("FrequenciaVooId");

                    b.ToTable("Tbl_Frequencia_Voo");
                });

            modelBuilder.Entity("Fiap.Aula05.Web.Models.Passagem", b =>
                {
                    b.Property<int>("PassagemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PassagemId"), 1L, 1);

                    b.Property<decimal>("Tarifa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Titular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VooId")
                        .HasColumnType("int");

                    b.HasKey("PassagemId");

                    b.HasIndex("VooId");

                    b.ToTable("Passagens");
                });

            modelBuilder.Entity("Fiap.Aula05.Web.Models.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicoId"), 1L, 1);

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ServicoId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("Fiap.Aula05.Web.Models.Voo", b =>
                {
                    b.Property<int>("VooId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VooId"), 1L, 1);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destino")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("Duracao")
                        .HasColumnType("real");

                    b.Property<bool>("Escala")
                        .HasColumnType("bit");

                    b.Property<int>("FrequenciaVooId")
                        .HasColumnType("int");

                    b.Property<string>("Origem")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("VooId");

                    b.HasIndex("FrequenciaVooId");

                    b.ToTable("Tbl_Voo");
                });

            modelBuilder.Entity("Fiap.Aula05.Web.Models.VooServico", b =>
                {
                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.Property<int>("VooId")
                        .HasColumnType("int");

                    b.HasKey("ServicoId", "VooId");

                    b.HasIndex("VooId");

                    b.ToTable("VoosServicos");
                });

            modelBuilder.Entity("Fiap.Aula05.Web.Models.Passagem", b =>
                {
                    b.HasOne("Fiap.Aula05.Web.Models.Voo", "Voo")
                        .WithMany("Passagens")
                        .HasForeignKey("VooId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Voo");
                });

            modelBuilder.Entity("Fiap.Aula05.Web.Models.Voo", b =>
                {
                    b.HasOne("Fiap.Aula05.Web.Models.FrequenciaVoo", "Frequencia")
                        .WithMany()
                        .HasForeignKey("FrequenciaVooId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Frequencia");
                });

            modelBuilder.Entity("Fiap.Aula05.Web.Models.VooServico", b =>
                {
                    b.HasOne("Fiap.Aula05.Web.Models.Servico", "Servico")
                        .WithMany("VoosServicos")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Aula05.Web.Models.Voo", "Voo")
                        .WithMany("VoosServicos")
                        .HasForeignKey("VooId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Servico");

                    b.Navigation("Voo");
                });

            modelBuilder.Entity("Fiap.Aula05.Web.Models.Servico", b =>
                {
                    b.Navigation("VoosServicos");
                });

            modelBuilder.Entity("Fiap.Aula05.Web.Models.Voo", b =>
                {
                    b.Navigation("Passagens");

                    b.Navigation("VoosServicos");
                });
#pragma warning restore 612, 618
        }
    }
}
