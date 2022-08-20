using Microsoft.EntityFrameworkCore.Migrations;

namespace muhasebe.data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcessCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Process",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acıklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kayıp = table.Column<int>(type: "int", nullable: false),
                    Kazanc = table.Column<int>(type: "int", nullable: false),
                    ProcessCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Process", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Process_ProcessCategories_ProcessCategoryId",
                        column: x => x.ProcessCategoryId,
                        principalTable: "ProcessCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Process_ProcessCategoryId",
                table: "Process",
                column: "ProcessCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Process");

            migrationBuilder.DropTable(
                name: "ProcessCategories");
        }
    }
}
