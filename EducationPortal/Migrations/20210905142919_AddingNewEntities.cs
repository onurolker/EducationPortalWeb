using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationPortal.Migrations
{
    public partial class AddingNewEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationCategoriesViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationCategoriesViewModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationEducatorsViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducatorsName = table.Column<string>(maxLength: 70, nullable: false),
                    EducatorsRole = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationEducatorsViewModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationName = table.Column<string>(maxLength: 200, nullable: false),
                    EducationCategoriesViewModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationViewModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationViewModels_EducationCategoriesViewModels_EducationCategoriesViewModelId",
                        column: x => x.EducationCategoriesViewModelId,
                        principalTable: "EducationCategoriesViewModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationDetailsViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationDetailFilePath = table.Column<string>(maxLength: 1000, nullable: false),
                    EducationDetailDailyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EducationDetailQuota = table.Column<int>(nullable: false),
                    EducationDetailTotalTime = table.Column<TimeSpan>(nullable: false),
                    EducationViewModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDetailsViewModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDetailsViewModels_EducationViewModels_EducationViewModelId",
                        column: x => x.EducationViewModelId,
                        principalTable: "EducationViewModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationEducatorAndEducation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationViewModelId = table.Column<int>(nullable: false),
                    EducationEducatorsViewModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationEducatorAndEducation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationEducatorAndEducation_EducationEducatorsViewModels_EducationEducatorsViewModelId",
                        column: x => x.EducationEducatorsViewModelId,
                        principalTable: "EducationEducatorsViewModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationEducatorAndEducation_EducationViewModels_EducationViewModelId",
                        column: x => x.EducationViewModelId,
                        principalTable: "EducationViewModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationDetailsViewModels_EducationViewModelId",
                table: "EducationDetailsViewModels",
                column: "EducationViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationEducatorAndEducation_EducationEducatorsViewModelId",
                table: "EducationEducatorAndEducation",
                column: "EducationEducatorsViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationEducatorAndEducation_EducationViewModelId",
                table: "EducationEducatorAndEducation",
                column: "EducationViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationViewModels_EducationCategoriesViewModelId",
                table: "EducationViewModels",
                column: "EducationCategoriesViewModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationDetailsViewModels");

            migrationBuilder.DropTable(
                name: "EducationEducatorAndEducation");

            migrationBuilder.DropTable(
                name: "EducationEducatorsViewModels");

            migrationBuilder.DropTable(
                name: "EducationViewModels");

            migrationBuilder.DropTable(
                name: "EducationCategoriesViewModels");
        }
    }
}
