using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdemyCarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_about_changed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Cars_CarID",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_CarID",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "CarDescriptionID",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "CarID",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "Details",
                table: "Abouts",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Abouts",
                newName: "Details");

            migrationBuilder.AddColumn<int>(
                name: "CarDescriptionID",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CarID",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_CarID",
                table: "Abouts",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Cars_CarID",
                table: "Abouts",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
