using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sagep.Infra.Data.Migrations
{
    public partial class v006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AndamentoPenal_DetentoId",
                table: "AndamentoPenal");

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscrita",
                keyColumn: "Id",
                keyValue: new Guid("8d7fb6ec-bcbf-4f94-ad0a-0f7154e8670b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 589, DateTimeKind.Local).AddTicks(3453), new DateTime(2022, 12, 20, 19, 56, 33, 589, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("0b0aac0b-805d-4ed5-b6cf-d7a03a4e77f1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 591, DateTimeKind.Local).AddTicks(2730), new DateTime(2022, 12, 20, 19, 56, 33, 591, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("1b82c38c-5fa9-484c-ba40-c2aa8183652e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 591, DateTimeKind.Local).AddTicks(1843), new DateTime(2022, 12, 20, 19, 56, 33, 591, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("38b52b32-6e69-438d-bce7-e9b75fda6cf3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 591, DateTimeKind.Local).AddTicks(2767), new DateTime(2022, 12, 20, 19, 56, 33, 591, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("e98df615-1bfd-4eb6-8f89-a91c3378db22"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 591, DateTimeKind.Local).AddTicks(2774), new DateTime(2022, 12, 20, 19, 56, 33, 591, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("f312ed91-b8a1-4a23-9c57-f24dac794089"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 591, DateTimeKind.Local).AddTicks(2760), new DateTime(2022, 12, 20, 19, 56, 33, 591, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("6f119f2e-09c7-449a-b4cc-801cf66d1b19"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 595, DateTimeKind.Local).AddTicks(720), new DateTime(2022, 12, 20, 19, 56, 33, 595, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("82c15cda-87f5-4f8a-835e-26b8d45d2b03"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 595, DateTimeKind.Local).AddTicks(713), new DateTime(2022, 12, 20, 19, 56, 33, 595, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c1e37ce0-4d59-48da-869f-b0dd59562f26"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 595, DateTimeKind.Local).AddTicks(707), new DateTime(2022, 12, 20, 19, 56, 33, 595, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c503712d-6177-45c1-94d6-4be7cb00e4d8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 594, DateTimeKind.Local).AddTicks(9791), new DateTime(2022, 12, 20, 19, 56, 33, 594, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("e94b5df4-379c-482d-99e0-10e35760d580"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 595, DateTimeKind.Local).AddTicks(675), new DateTime(2022, 12, 20, 19, 56, 33, 595, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntasGrupos",
                keyColumn: "Id",
                keyValue: new Guid("b6da5dc4-2f08-4dc7-81df-8b1915bfab06"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 593, DateTimeKind.Local).AddTicks(3029), new DateTime(2022, 12, 20, 19, 56, 33, 593, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 586, DateTimeKind.Local).AddTicks(2302), new DateTime(2022, 12, 20, 19, 56, 33, 586, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("522eb3d9-e64d-4585-8776-e80f90cd9a0c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 587, DateTimeKind.Local).AddTicks(1178), new DateTime(2022, 12, 20, 19, 56, 33, 587, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("c959c0e8-24c9-4714-929f-5536bcd5dc0a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 20, 19, 56, 33, 587, DateTimeKind.Local).AddTicks(1238), new DateTime(2022, 12, 20, 19, 56, 33, 587, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.CreateIndex(
                name: "IX_AndamentoPenal_DetentoId",
                table: "AndamentoPenal",
                column: "DetentoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AndamentoPenal_DetentoId",
                table: "AndamentoPenal");

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscrita",
                keyColumn: "Id",
                keyValue: new Guid("8d7fb6ec-bcbf-4f94-ad0a-0f7154e8670b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 450, DateTimeKind.Local).AddTicks(9469), new DateTime(2022, 12, 17, 12, 35, 52, 450, DateTimeKind.Local).AddTicks(9503) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("0b0aac0b-805d-4ed5-b6cf-d7a03a4e77f1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 453, DateTimeKind.Local).AddTicks(3588), new DateTime(2022, 12, 17, 12, 35, 52, 453, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("1b82c38c-5fa9-484c-ba40-c2aa8183652e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 453, DateTimeKind.Local).AddTicks(2504), new DateTime(2022, 12, 17, 12, 35, 52, 453, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("38b52b32-6e69-438d-bce7-e9b75fda6cf3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 453, DateTimeKind.Local).AddTicks(3631), new DateTime(2022, 12, 17, 12, 35, 52, 453, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("e98df615-1bfd-4eb6-8f89-a91c3378db22"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 453, DateTimeKind.Local).AddTicks(3638), new DateTime(2022, 12, 17, 12, 35, 52, 453, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("f312ed91-b8a1-4a23-9c57-f24dac794089"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 453, DateTimeKind.Local).AddTicks(3624), new DateTime(2022, 12, 17, 12, 35, 52, 453, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("6f119f2e-09c7-449a-b4cc-801cf66d1b19"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 459, DateTimeKind.Local).AddTicks(3862), new DateTime(2022, 12, 17, 12, 35, 52, 459, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("82c15cda-87f5-4f8a-835e-26b8d45d2b03"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 459, DateTimeKind.Local).AddTicks(3856), new DateTime(2022, 12, 17, 12, 35, 52, 459, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c1e37ce0-4d59-48da-869f-b0dd59562f26"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 459, DateTimeKind.Local).AddTicks(3849), new DateTime(2022, 12, 17, 12, 35, 52, 459, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c503712d-6177-45c1-94d6-4be7cb00e4d8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 459, DateTimeKind.Local).AddTicks(2766), new DateTime(2022, 12, 17, 12, 35, 52, 459, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("e94b5df4-379c-482d-99e0-10e35760d580"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 459, DateTimeKind.Local).AddTicks(3812), new DateTime(2022, 12, 17, 12, 35, 52, 459, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntasGrupos",
                keyColumn: "Id",
                keyValue: new Guid("b6da5dc4-2f08-4dc7-81df-8b1915bfab06"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 456, DateTimeKind.Local).AddTicks(3250), new DateTime(2022, 12, 17, 12, 35, 52, 456, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 447, DateTimeKind.Local).AddTicks(1834), new DateTime(2022, 12, 17, 12, 35, 52, 448, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("522eb3d9-e64d-4585-8776-e80f90cd9a0c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 448, DateTimeKind.Local).AddTicks(1845), new DateTime(2022, 12, 17, 12, 35, 52, 448, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("c959c0e8-24c9-4714-929f-5536bcd5dc0a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 17, 12, 35, 52, 448, DateTimeKind.Local).AddTicks(1906), new DateTime(2022, 12, 17, 12, 35, 52, 448, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.CreateIndex(
                name: "IX_AndamentoPenal_DetentoId",
                table: "AndamentoPenal",
                column: "DetentoId",
                unique: true,
                filter: "\"IsDeleted\"='0'");
        }
    }
}
