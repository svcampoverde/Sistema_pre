using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class add_nombre_producto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdTipoProducto",
                table: "productos",
                newName: "idTipoProducto");

            migrationBuilder.RenameColumn(
                name: "IdCategoriaProducto",
                table: "productos",
                newName: "idCategoriaProducto");

            migrationBuilder.RenameIndex(
                name: "IX_productos_IdTipoProducto",
                table: "productos",
                newName: "IX_productos_idTipoProducto");

            migrationBuilder.RenameIndex(
                name: "IX_productos_IdCategoriaProducto",
                table: "productos",
                newName: "IX_productos_idCategoriaProducto");

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "productos",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 642, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 649, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 664, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 722, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 735, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "tipo_servicio",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 12, 1, 8, 40, 738, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429), new DateTime(2024, 7, 12, 1, 8, 40, 728, DateTimeKind.Utc).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428), new DateTime(2024, 7, 12, 1, 8, 40, 731, DateTimeKind.Utc).AddTicks(9428) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "productos");

            migrationBuilder.RenameColumn(
                name: "idTipoProducto",
                table: "productos",
                newName: "IdTipoProducto");

            migrationBuilder.RenameColumn(
                name: "idCategoriaProducto",
                table: "productos",
                newName: "IdCategoriaProducto");

            migrationBuilder.RenameIndex(
                name: "IX_productos_idTipoProducto",
                table: "productos",
                newName: "IX_productos_IdTipoProducto");

            migrationBuilder.RenameIndex(
                name: "IX_productos_idCategoriaProducto",
                table: "productos",
                newName: "IX_productos_IdCategoriaProducto");

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 21,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 22,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 23,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 24,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 25,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 26,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 27,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 28,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 29,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "bancos",
                keyColumn: "id",
                keyValue: 30,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 2, 995, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 0, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 0, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 0, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 0, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 0, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 0, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 0, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 0, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "categorias_bancos",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 0, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 16, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 16, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 16, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 16, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 16, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 16, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 16, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 16, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 16, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "categorias_producto",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 16, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 77, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 2,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 3,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 4,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 5,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 6,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 7,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 8,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 9,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 10,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 11,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 12,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 13,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 14,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 15,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 16,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 17,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 18,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 19,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 20,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 31,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 32,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 33,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 34,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 35,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 36,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 37,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 38,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 39,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_producto",
                keyColumn: "id",
                keyValue: 40,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 87, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "tipo_servicio",
                keyColumn: "id",
                keyValue: 1,
                column: "fecha_creacion_utc",
                value: new DateTime(2024, 7, 11, 20, 53, 3, 91, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 11, 20, 53, 3, 81, DateTimeKind.Utc).AddTicks(7073), new DateTime(2024, 7, 11, 20, 53, 3, 81, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 11, 20, 53, 3, 81, DateTimeKind.Utc).AddTicks(7073), new DateTime(2024, 7, 11, 20, 53, 3, 81, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 11, 20, 53, 3, 81, DateTimeKind.Utc).AddTicks(7073), new DateTime(2024, 7, 11, 20, 53, 3, 81, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 11, 20, 53, 3, 81, DateTimeKind.Utc).AddTicks(7073), new DateTime(2024, 7, 11, 20, 53, 3, 81, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "tipocuenta",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 11, 20, 53, 3, 81, DateTimeKind.Utc).AddTicks(7073), new DateTime(2024, 7, 11, 20, 53, 3, 81, DateTimeKind.Utc).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 11, 20, 53, 3, 83, DateTimeKind.Utc).AddTicks(7097), new DateTime(2024, 7, 11, 20, 53, 3, 83, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 11, 20, 53, 3, 83, DateTimeKind.Utc).AddTicks(7097), new DateTime(2024, 7, 11, 20, 53, 3, 83, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 11, 20, 53, 3, 83, DateTimeKind.Utc).AddTicks(7097), new DateTime(2024, 7, 11, 20, 53, 3, 83, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 11, 20, 53, 3, 83, DateTimeKind.Utc).AddTicks(7097), new DateTime(2024, 7, 11, 20, 53, 3, 83, DateTimeKind.Utc).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "tipoempresa",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "fecha_creacion_utc", "fecha_modificacion_utc" },
                values: new object[] { new DateTime(2024, 7, 11, 20, 53, 3, 83, DateTimeKind.Utc).AddTicks(7097), new DateTime(2024, 7, 11, 20, 53, 3, 83, DateTimeKind.Utc).AddTicks(7097) });
        }
    }
}
