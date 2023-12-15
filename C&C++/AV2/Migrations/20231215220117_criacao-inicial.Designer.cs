﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ORM5SBD.Data;

#nullable disable

namespace ORM5SBD.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231215220117_criacao-inicial")]
    partial class criacaoinicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ORM5SBD.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cpf");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Endereco");

                    b.Property<bool>("isDelet")
                        .HasColumnType("bit")
                        .HasColumnName("isDelet");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("id");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("ORM5SBD.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DisciplinaId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Credito")
                        .HasColumnType("int")
                        .HasColumnName("Credito");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<int>("Periodo")
                        .HasColumnType("int")
                        .HasColumnName("Periodo");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Sigla");

                    b.HasKey("Id");

                    b.ToTable("Disciplina");
                });

            modelBuilder.Entity("ORM5SBD.Models.Inscricao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("InscricaoId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("AV1")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("AV1");

                    b.Property<decimal?>("AV2")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("AV2");

                    b.Property<decimal?>("AVF")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("AVF");

                    b.Property<DateTime>("FinalPeriodo")
                        .HasColumnType("datetime2")
                        .HasColumnName("FinalPeriodo");

                    b.Property<int>("Frequencia")
                        .HasColumnType("int")
                        .HasColumnName("Frequencia");

                    b.Property<DateTime>("InicioPeriodo")
                        .HasColumnType("datetime2")
                        .HasColumnName("InicioPeriodo");

                    b.Property<int>("TurmaId")
                        .HasColumnType("int")
                        .HasColumnName("TurmaId");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("AlunoId");

                    b.HasKey("Id");

                    b.HasIndex("TurmaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Inscricao");
                });

            modelBuilder.Entity("ORM5SBD.Models.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cpf");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Endereco");

                    b.Property<bool>("IsAdminstration")
                        .HasColumnType("bit")
                        .HasColumnName("IsAdminstration");

                    b.Property<bool>("isDelet")
                        .HasColumnType("bit")
                        .HasColumnName("isDelet");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("id");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("ORM5SBD.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int")
                        .HasColumnName("DisciplinaId");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int")
                        .HasColumnName("ProfessorId");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("ORM5SBD.Models.Inscricao", b =>
                {
                    b.HasOne("ORM5SBD.Models.Turma", "Turma")
                        .WithMany()
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ORM5SBD.Models.Aluno", "Usuario")
                        .WithMany("inscricoes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turma");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ORM5SBD.Models.Turma", b =>
                {
                    b.HasOne("ORM5SBD.Models.Disciplina", "Disciplina")
                        .WithMany("TurmaList")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ORM5SBD.Models.Professor", "Professor")
                        .WithMany("turmas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disciplina");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("ORM5SBD.Models.Aluno", b =>
                {
                    b.Navigation("inscricoes");
                });

            modelBuilder.Entity("ORM5SBD.Models.Disciplina", b =>
                {
                    b.Navigation("TurmaList");
                });

            modelBuilder.Entity("ORM5SBD.Models.Professor", b =>
                {
                    b.Navigation("turmas");
                });
#pragma warning restore 612, 618
        }
    }
}
