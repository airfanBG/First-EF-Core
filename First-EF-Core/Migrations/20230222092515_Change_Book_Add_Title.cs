using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace First_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class Change_Book_Add_Title : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Books");
        }
    }
}
