using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HubCollege.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaFormsActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_college",
                table: "college");

            migrationBuilder.RenameTable(
                name: "college",
                newName: "FormsActivities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FormsActivities",
                table: "FormsActivities",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FormsActivities",
                table: "FormsActivities");

            migrationBuilder.RenameTable(
                name: "FormsActivities",
                newName: "college");

            migrationBuilder.AddPrimaryKey(
                name: "PK_college",
                table: "college",
                column: "Id");
        }
    }
}
