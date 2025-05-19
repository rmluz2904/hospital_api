using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hospital_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospitais",
                columns: table => new
                {
                    HospitalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitais", x => x.HospitalId);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NIF = table.Column<int>(type: "int", nullable: false),
                    Morada = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteId);
                });

            migrationBuilder.CreateTable(
                name: "ProfissionaisSaude",
                columns: table => new
                {
                    ProfissionalSaudeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroMecanografico = table.Column<int>(type: "int", nullable: false),
                    NomeProfissionalSaude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hospital = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    EnfermeiroId = table.Column<int>(type: "int", nullable: true),
                    NumeroOrdemEnfermeiros = table.Column<int>(type: "int", nullable: true),
                    MedicoId = table.Column<int>(type: "int", nullable: true),
                    NumeroOrdemMedicos = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfissionaisSaude", x => x.ProfissionalSaudeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hospitais");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "ProfissionaisSaude");
        }
    }
}
