﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Sgiq.Dados;
using System;

namespace Sgiq.Dados.Migrations
{
    [DbContext(typeof(SGIQContext))]
    [Migration("20171208223351_metrica")]
    partial class metrica
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Sgiq.Dados.Models.Atividade", b =>
                {
                    b.Property<int>("AtividadeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime>("DtInicioPrevista")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DtTerminoPrevista")
                        .HasColumnType("datetime");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<int>("ProjetoId");

                    b.HasKey("AtividadeId");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Atividade");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.AvaliacaoProjeto", b =>
                {
                    b.Property<int>("ProjetoId");

                    b.Property<string>("Chave")
                        .IsRequired();

                    b.Property<DateTime>("DtAvaliacao");

                    b.Property<int>("ParteInteressadaId");

                    b.Property<int>("VlrAvaliacao");

                    b.HasKey("ProjetoId");

                    b.HasIndex("ParteInteressadaId")
                        .IsUnique();

                    b.ToTable("AvaliacaoProjeto");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.AvaliacaoRequisito", b =>
                {
                    b.Property<int>("RequisitoId");

                    b.Property<DateTime>("DtAvaliacao");

                    b.Property<int>("VlrAvaliacao");

                    b.HasKey("RequisitoId");

                    b.ToTable("AvaliacaoRequisito");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Condicao", b =>
                {
                    b.Property<int>("CondicaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("CondicaoId");

                    b.ToTable("Condicao");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.FrequenciaAfericao", b =>
                {
                    b.Property<int>("FrequenciaAfericaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(45);

                    b.HasKey("FrequenciaAfericaoId");

                    b.ToTable("FrequenciaAfericao");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Indicador", b =>
                {
                    b.Property<int>("IndicadorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(60);

                    b.Property<int>("MetricaId");

                    b.Property<string>("Nome")
                        .HasMaxLength(30);

                    b.HasKey("IndicadorId");

                    b.HasIndex("MetricaId");

                    b.ToTable("Indicador");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.IndicadorProjeto", b =>
                {
                    b.Property<int>("IndicadorId");

                    b.Property<int>("ProjetoId");

                    b.HasKey("IndicadorId", "ProjetoId");

                    b.HasIndex("ProjetoId");

                    b.ToTable("IndicadorProjeto");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Medicao", b =>
                {
                    b.Property<int>("MedicaoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtInclusao");

                    b.Property<int>("MedidaId");

                    b.Property<int>("ProjetoId");

                    b.Property<decimal>("Valor");

                    b.HasKey("MedicaoId");

                    b.HasIndex("MedidaId");

                    b.HasIndex("ProjetoId");

                    b.ToTable("Medicao");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Medida", b =>
                {
                    b.Property<int>("MedidaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("TipoDadoId");

                    b.Property<decimal>("VlrMaximo");

                    b.Property<decimal>("VlrMinimo");

                    b.HasKey("MedidaId");

                    b.HasIndex("TipoDadoId");

                    b.ToTable("Medida");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.MedidaMetrica", b =>
                {
                    b.Property<int>("MedidaId");

                    b.Property<int>("MetricaId");

                    b.HasKey("MedidaId", "MetricaId");

                    b.HasIndex("MetricaId");

                    b.ToTable("MedidaMetrica");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.MetaIndicador", b =>
                {
                    b.Property<int>("MetaIndicadorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CondicaoId");

                    b.Property<int>("IndicadorId");

                    b.Property<decimal>("Valor");

                    b.HasKey("MetaIndicadorId");

                    b.HasIndex("CondicaoId");

                    b.HasIndex("IndicadorId");

                    b.ToTable("MetaIndicador");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Metrica", b =>
                {
                    b.Property<int>("MetricaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Formula")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("FrequenciaAfericaoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("MetricaId");

                    b.HasIndex("FrequenciaAfericaoId");

                    b.ToTable("Metrica");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Papel", b =>
                {
                    b.Property<int>("PapelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("PapelId");

                    b.ToTable("Papel");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.ParteInteressada", b =>
                {
                    b.Property<int>("ParteInteressadaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Telefone")
                        .HasMaxLength(12);

                    b.HasKey("ParteInteressadaId");

                    b.ToTable("ParteInteressada");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.ParteInteressadaProjeto", b =>
                {
                    b.Property<int>("ProjetoId");

                    b.Property<int>("ParteInteressadaId");

                    b.Property<int>("PapelId");

                    b.HasKey("ProjetoId", "ParteInteressadaId");

                    b.HasAlternateKey("ParteInteressadaId", "ProjetoId");

                    b.HasIndex("PapelId");

                    b.ToTable("ParteInteressadaProjeto");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Projeto", b =>
                {
                    b.Property<int>("ProjetoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CustoEstimado");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime>("DtInicioPrevista")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DtTerminoPrevista")
                        .HasColumnType("datetime");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<int>("SituacaoProjetoId");

                    b.HasKey("ProjetoId");

                    b.HasIndex("SituacaoProjetoId");

                    b.ToTable("Projeto");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Requisito", b =>
                {
                    b.Property<int>("RequisitoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime>("DtInclusao")
                        .HasColumnType("datetime");

                    b.Property<int>("ProjetoId");

                    b.Property<int>("TipoRequisitoId");

                    b.HasKey("RequisitoId");

                    b.HasIndex("ProjetoId");

                    b.HasIndex("TipoRequisitoId");

                    b.ToTable("Requisito");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.SituacaoProjeto", b =>
                {
                    b.Property<int>("SituacaoProjetoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("SituacaoProjetoId");

                    b.ToTable("SituacaoProjeto");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.TipoDado", b =>
                {
                    b.Property<int>("TipoDadoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("TipoDadoId");

                    b.ToTable("TipoDado");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.TipoRequisito", b =>
                {
                    b.Property<int>("TipoRequisitoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("TipoRequisitoId");

                    b.ToTable("TipoRequisito");
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Atividade", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.Projeto")
                        .WithMany("Atividades")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.AvaliacaoProjeto", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.ParteInteressada", "ParteInteressada")
                        .WithOne("AvaliacaoProjeto")
                        .HasForeignKey("Sgiq.Dados.Models.AvaliacaoProjeto", "ParteInteressadaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sgiq.Dados.Models.Projeto", "Projeto")
                        .WithOne("AvaliacaoProjeto")
                        .HasForeignKey("Sgiq.Dados.Models.AvaliacaoProjeto", "ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.AvaliacaoRequisito", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.Requisito", "Requisito")
                        .WithOne("AvaliacaoRequisito")
                        .HasForeignKey("Sgiq.Dados.Models.AvaliacaoRequisito", "RequisitoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Indicador", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.Metrica", "Metrica")
                        .WithMany()
                        .HasForeignKey("MetricaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.IndicadorProjeto", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.Indicador", "Indicador")
                        .WithMany("IndicadoresProjeto")
                        .HasForeignKey("IndicadorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sgiq.Dados.Models.Projeto", "Projeto")
                        .WithMany("IndicadoresProjeto")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Medicao", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.Medida", "Medida")
                        .WithMany("Medicoes")
                        .HasForeignKey("MedidaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sgiq.Dados.Models.Projeto", "Projeto")
                        .WithMany("Medicoes")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Medida", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.TipoDado", "TipoDado")
                        .WithMany()
                        .HasForeignKey("TipoDadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.MedidaMetrica", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.Medida", "Medida")
                        .WithMany("MedidasMetrica")
                        .HasForeignKey("MedidaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sgiq.Dados.Models.Metrica", "Metrica")
                        .WithMany("MedidasMetrica")
                        .HasForeignKey("MetricaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.MetaIndicador", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.Condicao", "Condicao")
                        .WithMany()
                        .HasForeignKey("CondicaoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sgiq.Dados.Models.Indicador")
                        .WithMany("MetasIndicador")
                        .HasForeignKey("IndicadorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Metrica", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.FrequenciaAfericao", "FrequenciaAfericao")
                        .WithMany("Metricas")
                        .HasForeignKey("FrequenciaAfericaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.ParteInteressadaProjeto", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.Papel", "Papel")
                        .WithMany("PartesInteressadasProjeto")
                        .HasForeignKey("PapelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sgiq.Dados.Models.ParteInteressada", "ParteInteressada")
                        .WithMany("PartesInteressadasProjeto")
                        .HasForeignKey("ParteInteressadaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sgiq.Dados.Models.Projeto", "Projeto")
                        .WithMany("PartesInteressadasProjeto")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Projeto", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.SituacaoProjeto", "SituacaoProjeto")
                        .WithMany("Projetos")
                        .HasForeignKey("SituacaoProjetoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sgiq.Dados.Models.Requisito", b =>
                {
                    b.HasOne("Sgiq.Dados.Models.Projeto", "Projeto")
                        .WithMany("Requisitos")
                        .HasForeignKey("ProjetoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Sgiq.Dados.Models.TipoRequisito", "TipoRequisito")
                        .WithMany("Requisitos")
                        .HasForeignKey("TipoRequisitoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
