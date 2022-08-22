using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TsManager.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anexos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    IdRegistro = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    URLAnexo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EquipesAtendimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DataRegistro = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Ativo = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipesAtendimento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Senha = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Severidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    Classificacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EnviarEmail = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Severidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Slas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    Indicador = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Tempo = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DepartamentoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LoginId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Usuarios_Logins_LoginId",
                        column: x => x.LoginId,
                        principalTable: "Logins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoRegistros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    SlaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRegistros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoRegistros_Slas_SlaId",
                        column: x => x.SlaId,
                        principalTable: "Slas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnalistaEquipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    EquipeAtendimentoId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    EquipeId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalistaEquipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnalistaEquipes_EquipesAtendimento_EquipeAtendimentoId",
                        column: x => x.EquipeAtendimentoId,
                        principalTable: "EquipesAtendimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnalistaEquipes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioChamados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ChamadoID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioChamados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioChamados_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chamados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TipoRegistroId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SeveridadeId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    AnexoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Localizacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Analista_EquipeId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    EquipeId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TecnicoId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DataEncerramento = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    StatusId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chamados_AnalistaEquipes_Analista_EquipeId",
                        column: x => x.Analista_EquipeId,
                        principalTable: "AnalistaEquipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chamados_Anexos_AnexoId",
                        column: x => x.AnexoId,
                        principalTable: "Anexos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chamados_Severidades_SeveridadeId",
                        column: x => x.SeveridadeId,
                        principalTable: "Severidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chamados_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chamados_TipoRegistros_TipoRegistroId",
                        column: x => x.TipoRegistroId,
                        principalTable: "TipoRegistros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chamados_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Historicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "1, 1"),
                    IdRegistro = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    IdTecnico = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DataAcao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ChamadoId = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historicos_Chamados_ChamadoId",
                        column: x => x.ChamadoId,
                        principalTable: "Chamados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnalistaEquipes_EquipeAtendimentoId",
                table: "AnalistaEquipes",
                column: "EquipeAtendimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_AnalistaEquipes_UsuarioId",
                table: "AnalistaEquipes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_Analista_EquipeId",
                table: "Chamados",
                column: "Analista_EquipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_AnexoId",
                table: "Chamados",
                column: "AnexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_SeveridadeId",
                table: "Chamados",
                column: "SeveridadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_StatusId",
                table: "Chamados",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_TipoRegistroId",
                table: "Chamados",
                column: "TipoRegistroId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamados_UsuarioId",
                table: "Chamados",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Historicos_ChamadoId",
                table: "Historicos",
                column: "ChamadoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoRegistros_SlaId",
                table: "TipoRegistros",
                column: "SlaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioChamados_UsuarioId",
                table: "UsuarioChamados",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_DepartamentoId",
                table: "Usuarios",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_LoginId",
                table: "Usuarios",
                column: "LoginId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Historicos");

            migrationBuilder.DropTable(
                name: "UsuarioChamados");

            migrationBuilder.DropTable(
                name: "Chamados");

            migrationBuilder.DropTable(
                name: "AnalistaEquipes");

            migrationBuilder.DropTable(
                name: "Anexos");

            migrationBuilder.DropTable(
                name: "Severidades");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "TipoRegistros");

            migrationBuilder.DropTable(
                name: "EquipesAtendimento");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Slas");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Logins");
        }
    }
}
