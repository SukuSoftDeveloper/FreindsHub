using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreindsHub.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFreindsTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Freinds",
                table: "Freinds");

            migrationBuilder.RenameTable(
                name: "Freinds",
                newName: "Friends");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                table: "Friends",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                table: "Friends");

            migrationBuilder.RenameTable(
                name: "Friends",
                newName: "Freinds");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Freinds",
                table: "Freinds",
                column: "Id");
        }
    }
}
