﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.API.Data;

#nullable disable

namespace SmartSchool.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220225152110_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("SmartSchool.API.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInic")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<int>("Matricula")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7714),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7731),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 2,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7736),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 3,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7741),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 4,
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7746),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 5,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7751),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 6,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7755),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 7,
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunosCursos");
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7778)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7782)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7783)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7784)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7785)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7787)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7788)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7789)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7790)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7792)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7793)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7794)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7795)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7796)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7797)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7798)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7799)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7801)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7802)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7803)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7804)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7805)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5,
                            DataIni = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7806)
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NomeCurso")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NomeCurso = "Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 2,
                            NomeCurso = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            NomeCurso = "Ciência da Computação"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PreRequisitoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PreRequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 6,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 7,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 8,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 9,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 10,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataInic")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Registro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7160),
                            Nome = "Lauro",
                            Registro = 1,
                            Sobrenome = "Oliveira"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7178),
                            Nome = "Roberto",
                            Registro = 2,
                            Sobrenome = "Soares"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7179),
                            Nome = "Ronaldo",
                            Registro = 3,
                            Sobrenome = "Marconi"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7214),
                            Nome = "Rodrigo",
                            Registro = 4,
                            Sobrenome = "Carvalho"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataInic = new DateTime(2022, 2, 25, 12, 21, 10, 353, DateTimeKind.Local).AddTicks(7215),
                            Nome = "Alexandre",
                            Registro = 5,
                            Sobrenome = "Montanha"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoCurso", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Aluno", "Aluno")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Disciplina", "Disciplina")
                        .WithMany("AlunosDisciplinas")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");

                    b.Navigation("Disciplina");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Curso", "curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Disciplina", "PreRequisito")
                        .WithMany()
                        .HasForeignKey("PreRequisitoId");

                    b.HasOne("SmartSchool.API.Models.Professor", "Professor")
                        .WithMany("Disciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PreRequisito");

                    b.Navigation("Professor");

                    b.Navigation("curso");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Aluno", b =>
                {
                    b.Navigation("AlunosDisciplinas");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Curso", b =>
                {
                    b.Navigation("Disciplinas");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.Navigation("AlunosDisciplinas");
                });

            modelBuilder.Entity("SmartSchool.API.Models.Professor", b =>
                {
                    b.Navigation("Disciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}