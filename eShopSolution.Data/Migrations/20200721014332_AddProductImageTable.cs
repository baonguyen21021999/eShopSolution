using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c9ac66ec-2cde-4b5d-8ebf-2042a2115da9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "526eb64c-634b-4303-860e-21b823eaf836", "abc@gmail.com", "abc@gmail.com", "AQAAAAEAACcQAAAAECtjHAQppxFuDyatgOSnNimBV/xGnOarE/nNu0UCn+6qd/KH1qN2tX4LkP4EgAUQ1g==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 21, 8, 43, 32, 47, DateTimeKind.Local).AddTicks(2106));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "4142d605-b1ab-40de-ada3-acc0aa0de8e1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "7ab49b13-0b78-4c44-bd9b-11ea5c23e94f", "tedu.international@gmail.com", "tedu.international@gmail.com", "AQAAAAEAACcQAAAAELXHKihlYC1e7rgdM4nKeisMk70u045ew5b72NJUKkXElcMGxtns84+DVWmpUFmvzQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 19, 9, 21, 27, 193, DateTimeKind.Local).AddTicks(6451));
        }
    }
}
