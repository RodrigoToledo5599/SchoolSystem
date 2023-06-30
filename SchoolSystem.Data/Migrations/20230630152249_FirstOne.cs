using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    IdAluno = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serie = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.IdAluno);
                });

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    IdTurma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serie = table.Column<int>(type: "int", nullable: false),
                    Materia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.IdTurma);
                });

            migrationBuilder.CreateTable(
                name: "AlunoTurma",
                columns: table => new
                {
                    AlunosIdAluno = table.Column<int>(type: "int", nullable: false),
                    TurmasIdTurma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoTurma", x => new { x.AlunosIdAluno, x.TurmasIdTurma });
                    table.ForeignKey(
                        name: "FK_AlunoTurma_Alunos_AlunosIdAluno",
                        column: x => x.AlunosIdAluno,
                        principalTable: "Alunos",
                        principalColumn: "IdAluno",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunoTurma_Turmas_TurmasIdTurma",
                        column: x => x.TurmasIdTurma,
                        principalTable: "Turmas",
                        principalColumn: "IdTurma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    IdMateria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MateriaCode = table.Column<int>(type: "int", nullable: false),
                    TurmaIdTurma = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.IdMateria);
                    table.ForeignKey(
                        name: "FK_Materias_Turmas_TurmaIdTurma",
                        column: x => x.TurmaIdTurma,
                        principalTable: "Turmas",
                        principalColumn: "IdTurma");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlunoTurma_TurmasIdTurma",
                table: "AlunoTurma",
                column: "TurmasIdTurma");

            migrationBuilder.CreateIndex(
                name: "IX_Materias_TurmaIdTurma",
                table: "Materias",
                column: "TurmaIdTurma");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoTurma");

            migrationBuilder.DropTable(
                name: "Materias");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Turmas");
        }
    }
}
