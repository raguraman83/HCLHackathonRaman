using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CO2RedBackend.Migrations
{
    /// <inheritdoc />
    public partial class MigrationV6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlanId",
                table: "PLAN",
                newName: "CoidId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoidId",
                table: "PLAN",
                newName: "PlanId");
        }
    }
}
