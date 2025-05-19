using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hospital_api.Migrations
{
    /// <inheritdoc />
    public partial class AddEspecialidadeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Especialidade",
                table: "ProfissionaisSaude");

            migrationBuilder.AddColumn<int>(
                name: "EspecialidadeId",
                table: "ProfissionaisSaude",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    EspecialidadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.EspecialidadeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfissionaisSaude_EspecialidadeId",
                table: "ProfissionaisSaude",
                column: "EspecialidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfissionaisSaude_Especialidades_EspecialidadeId",
                table: "ProfissionaisSaude",
                column: "EspecialidadeId",
                principalTable: "Especialidades",
                principalColumn: "EspecialidadeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfissionaisSaude_Especialidades_EspecialidadeId",
                table: "ProfissionaisSaude");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropIndex(
                name: "IX_ProfissionaisSaude_EspecialidadeId",
                table: "ProfissionaisSaude");

            migrationBuilder.DropColumn(
                name: "EspecialidadeId",
                table: "ProfissionaisSaude");

            migrationBuilder.AddColumn<string>(
                name: "Especialidade",
                table: "ProfissionaisSaude",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
