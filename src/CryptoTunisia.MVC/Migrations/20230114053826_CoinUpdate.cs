using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoTunisia.MVC.Migrations
{
    /// <inheritdoc />
    public partial class CoinUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableSupply",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "MaxSupply",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "PercentChange1H",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "PercentChange7D",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "Rank",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "Slug",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "Symbol",
                table: "Coin");

            migrationBuilder.DropColumn(
                name: "TotalSupply",
                table: "Coin");

            migrationBuilder.RenameColumn(
                name: "Volume24H",
                table: "Coin",
                newName: "Volume");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Volume",
                table: "Coin",
                newName: "Volume24H");

            migrationBuilder.AddColumn<double>(
                name: "AvailableSupply",
                table: "Coin",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdated",
                table: "Coin",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "MaxSupply",
                table: "Coin",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PercentChange1H",
                table: "Coin",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PercentChange7D",
                table: "Coin",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "Coin",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Slug",
                table: "Coin",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Symbol",
                table: "Coin",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "TotalSupply",
                table: "Coin",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
