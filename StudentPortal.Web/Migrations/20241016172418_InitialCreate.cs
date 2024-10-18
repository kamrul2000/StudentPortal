using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentPortal.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Studnts",
                table: "Studnts");

            migrationBuilder.RenameTable(
                name: "Studnts",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "SubScribed",
                table: "Students",
                newName: "Subscribed");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Studnts");

            migrationBuilder.RenameColumn(
                name: "Subscribed",
                table: "Studnts",
                newName: "SubScribed");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studnts",
                table: "Studnts",
                column: "Id");
        }
    }
}
