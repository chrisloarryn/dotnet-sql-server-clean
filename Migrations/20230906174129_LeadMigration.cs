using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_backend.Migrations
{
    /// <inheritdoc />
    public partial class LeadMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Leads",
                newName: "TelMovil");

            migrationBuilder.AddColumn<string>(
                name: "CanalRegistro",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ciudad",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Clasificacion",
                table: "Leads",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Comuna",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dv",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EjecutivoAsignado",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Leads",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FchRegistro",
                table: "Leads",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PrimerApellido",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrimerNombre",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Prioridad",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rut",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SegundoApellido",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SegundoNombre",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sucursal",
                table: "Leads",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TipoLead",
                table: "Leads",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "Uuid",
                table: "Leads",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanalRegistro",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Clasificacion",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Comuna",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Dv",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "EjecutivoAsignado",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "FchRegistro",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "PrimerApellido",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "PrimerNombre",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Prioridad",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Rut",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "SegundoApellido",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "SegundoNombre",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Sucursal",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "TipoLead",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Uuid",
                table: "Leads");

            migrationBuilder.RenameColumn(
                name: "TelMovil",
                table: "Leads",
                newName: "Name");
        }
    }
}
