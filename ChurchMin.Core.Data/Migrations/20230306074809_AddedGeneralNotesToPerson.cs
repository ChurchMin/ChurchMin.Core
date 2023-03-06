using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChurchMin.Core.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedGeneralNotesToPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GeneralNotes",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GeneralNotes",
                table: "Person");
        }
    }
}
