using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "72f09118-7969-4d10-ad1a-e29a646aa496");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c581247-2a5a-466a-a7f3-e137f16f98cc", "AQAAAAEAACcQAAAAEKCqe9etnYBlFkPOJYqzaYF4TwCZ+k8W7ZyTIe3Q+eB8xjP2Pa+h3wY4dml+h14AYA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 11, 1, 21, 59, 893, DateTimeKind.Local).AddTicks(3874));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "49249bed-a4af-48a6-a4b7-f183f044a2c6");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5fd3352d-97d2-40e6-a6d9-1ce857bc2038", "AQAAAAEAACcQAAAAEN3XnRj/tNuUUeBEqCpnTaMfbt/iW0zwEny5b9wnurJnZn/pUu80UxXfce7C/KPg4g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 7, 1, 54, 9, 608, DateTimeKind.Local).AddTicks(7860));
        }
    }
}
