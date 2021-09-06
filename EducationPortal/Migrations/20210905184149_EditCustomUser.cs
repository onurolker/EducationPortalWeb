using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationPortal.Migrations
{
    public partial class EditCustomUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationEducatorAndEducation");

            migrationBuilder.DropTable(
                name: "EducationEducatorsViewModels");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "EducationUsersAndEducation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestJoin = table.Column<bool>(nullable: false),
                    EducationViewModelId = table.Column<int>(nullable: false),
                    CustomUserViewModelId1 = table.Column<string>(nullable: true),
                    CustomUserViewModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationUsersAndEducation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationUsersAndEducation_AspNetUsers_CustomUserViewModelId1",
                        column: x => x.CustomUserViewModelId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EducationUsersAndEducation_EducationViewModels_EducationViewModelId",
                        column: x => x.EducationViewModelId,
                        principalTable: "EducationViewModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationUsersAndEducation_CustomUserViewModelId1",
                table: "EducationUsersAndEducation",
                column: "CustomUserViewModelId1");

            migrationBuilder.CreateIndex(
                name: "IX_EducationUsersAndEducation_EducationViewModelId",
                table: "EducationUsersAndEducation",
                column: "EducationViewModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationUsersAndEducation");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "EducationEducatorsViewModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducatorsName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    EducatorsRole = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationEducatorsViewModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationEducatorAndEducation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationEducatorsViewModelId = table.Column<int>(type: "int", nullable: false),
                    EducationViewModelId = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_EducationEducatorAndEducation_EducationEducatorsViewModelId",
                table: "EducationEducatorAndEducation",
                column: "EducationEducatorsViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationEducatorAndEducation_EducationViewModelId",
                table: "EducationEducatorAndEducation",
                column: "EducationViewModelId");
        }
    }
}
