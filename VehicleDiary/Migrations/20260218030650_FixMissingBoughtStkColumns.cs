using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleDiary.Migrations
{
    /// <inheritdoc />
    public partial class FixMissingBoughtStkColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Bought",
                table: "DBVehiclesSet",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "STK",
                table: "DBVehiclesSet",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bought",
                table: "DBVehiclesSet");

            migrationBuilder.DropColumn(
                name: "STK",
                table: "DBVehiclesSet");
        }
    }
}
