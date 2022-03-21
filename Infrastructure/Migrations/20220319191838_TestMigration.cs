using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PreviaturasFing.Infrastructure.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubjectGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectSubGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectSubGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Credits = table.Column<int>(type: "int", nullable: false),
                    EvenSemester = table.Column<bool>(type: "bit", nullable: false),
                    OddSemester = table.Column<bool>(type: "bit", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    SubGroupId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_SubjectGroup_GroupId",
                        column: x => x.GroupId,
                        principalTable: "SubjectGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subjects_SubjectSubGroup_SubGroupId",
                        column: x => x.SubGroupId,
                        principalTable: "SubjectSubGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_GroupId",
                table: "Subjects",
                column: "GroupId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SubGroupId",
                table: "Subjects",
                column: "SubGroupId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "SubjectGroup");

            migrationBuilder.DropTable(
                name: "SubjectSubGroup");
        }
    }
}
