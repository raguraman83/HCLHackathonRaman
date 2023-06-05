using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CO2RedBackend.Migrations
{
    /// <inheritdoc />
    public partial class MigrationV5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CO2RedID",
                table: "PLAN",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PlanId",
                table: "PLAN",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_PLAN_CO2RedID",
                table: "PLAN",
                column: "CO2RedID");

            migrationBuilder.AddForeignKey(
                name: "FK_PLAN_CO2RED_CO2RedID",
                table: "PLAN",
                column: "CO2RedID",
                principalTable: "CO2RED",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PLAN_CO2RED_CO2RedID",
                table: "PLAN");

            migrationBuilder.DropIndex(
                name: "IX_PLAN_CO2RedID",
                table: "PLAN");

            migrationBuilder.DropColumn(
                name: "CO2RedID",
                table: "PLAN");

            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "PLAN");
        }
    }
}
