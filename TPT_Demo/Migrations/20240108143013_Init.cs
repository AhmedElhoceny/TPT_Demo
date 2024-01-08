using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPT_Demo.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Table1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PropertyForTable1 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Table1_BaseEntities_Id",
                        column: x => x.Id,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Table2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PropertyForTable2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Table2_BaseEntities_Id",
                        column: x => x.Id,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Table3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PropertyForTable3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table3", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Table3_BaseEntities_Id",
                        column: x => x.Id,
                        principalTable: "BaseEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table1");

            migrationBuilder.DropTable(
                name: "Table2");

            migrationBuilder.DropTable(
                name: "Table3");

            migrationBuilder.DropTable(
                name: "BaseEntities");
        }
    }
}
