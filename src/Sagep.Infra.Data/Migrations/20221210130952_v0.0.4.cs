using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sagep.Infra.Data.Migrations
{
    public partial class v004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ListaAmarela_DetentoId",
                table: "ListaAmarela");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: "1e526008-75f7-4a01-9942-d178f2b38888",
                column: "TenantId",
                value: new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                column: "TenantId",
                value: new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"));

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscrita",
                keyColumn: "Id",
                keyValue: new Guid("8d7fb6ec-bcbf-4f94-ad0a-0f7154e8670b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 422, DateTimeKind.Local).AddTicks(701), new DateTime(2022, 12, 10, 10, 9, 51, 422, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("0b0aac0b-805d-4ed5-b6cf-d7a03a4e77f1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 424, DateTimeKind.Local).AddTicks(3434), new DateTime(2022, 12, 10, 10, 9, 51, 424, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("1b82c38c-5fa9-484c-ba40-c2aa8183652e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 424, DateTimeKind.Local).AddTicks(2472), new DateTime(2022, 12, 10, 10, 9, 51, 424, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("38b52b32-6e69-438d-bce7-e9b75fda6cf3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 424, DateTimeKind.Local).AddTicks(3478), new DateTime(2022, 12, 10, 10, 9, 51, 424, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("e98df615-1bfd-4eb6-8f89-a91c3378db22"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 424, DateTimeKind.Local).AddTicks(3486), new DateTime(2022, 12, 10, 10, 9, 51, 424, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("f312ed91-b8a1-4a23-9c57-f24dac794089"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 424, DateTimeKind.Local).AddTicks(3471), new DateTime(2022, 12, 10, 10, 9, 51, 424, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("6f119f2e-09c7-449a-b4cc-801cf66d1b19"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 429, DateTimeKind.Local).AddTicks(3779), new DateTime(2022, 12, 10, 10, 9, 51, 429, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("82c15cda-87f5-4f8a-835e-26b8d45d2b03"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 429, DateTimeKind.Local).AddTicks(3772), new DateTime(2022, 12, 10, 10, 9, 51, 429, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c1e37ce0-4d59-48da-869f-b0dd59562f26"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 429, DateTimeKind.Local).AddTicks(3766), new DateTime(2022, 12, 10, 10, 9, 51, 429, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c503712d-6177-45c1-94d6-4be7cb00e4d8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 429, DateTimeKind.Local).AddTicks(1877), new DateTime(2022, 12, 10, 10, 9, 51, 429, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("e94b5df4-379c-482d-99e0-10e35760d580"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 429, DateTimeKind.Local).AddTicks(3724), new DateTime(2022, 12, 10, 10, 9, 51, 429, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntasGrupos",
                keyColumn: "Id",
                keyValue: new Guid("b6da5dc4-2f08-4dc7-81df-8b1915bfab06"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 426, DateTimeKind.Local).AddTicks(6779), new DateTime(2022, 12, 10, 10, 9, 51, 426, DateTimeKind.Local).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 418, DateTimeKind.Local).AddTicks(6199), new DateTime(2022, 12, 10, 10, 9, 51, 419, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("522eb3d9-e64d-4585-8776-e80f90cd9a0c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 419, DateTimeKind.Local).AddTicks(6225), new DateTime(2022, 12, 10, 10, 9, 51, 419, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("c959c0e8-24c9-4714-929f-5536bcd5dc0a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 12, 10, 10, 9, 51, 419, DateTimeKind.Local).AddTicks(6284), new DateTime(2022, 12, 10, 10, 9, 51, 419, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.CreateIndex(
                name: "IX_ListaAmarela_DetentoId",
                table: "ListaAmarela",
                column: "DetentoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ListaAmarela_DetentoId",
                table: "ListaAmarela");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: "1e526008-75f7-4a01-9942-d178f2b38888",
                column: "TenantId",
                value: new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "UserId",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                column: "TenantId",
                value: new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"));

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscrita",
                keyColumn: "Id",
                keyValue: new Guid("8d7fb6ec-bcbf-4f94-ad0a-0f7154e8670b"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 308, DateTimeKind.Local).AddTicks(7434), new DateTime(2022, 11, 24, 19, 43, 41, 308, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("0b0aac0b-805d-4ed5-b6cf-d7a03a4e77f1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 310, DateTimeKind.Local).AddTicks(6824), new DateTime(2022, 11, 24, 19, 43, 41, 310, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("1b82c38c-5fa9-484c-ba40-c2aa8183652e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 310, DateTimeKind.Local).AddTicks(5925), new DateTime(2022, 11, 24, 19, 43, 41, 310, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("38b52b32-6e69-438d-bce7-e9b75fda6cf3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 310, DateTimeKind.Local).AddTicks(6867), new DateTime(2022, 11, 24, 19, 43, 41, 310, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("e98df615-1bfd-4eb6-8f89-a91c3378db22"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 310, DateTimeKind.Local).AddTicks(6873), new DateTime(2022, 11, 24, 19, 43, 41, 310, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("f312ed91-b8a1-4a23-9c57-f24dac794089"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 310, DateTimeKind.Local).AddTicks(6860), new DateTime(2022, 11, 24, 19, 43, 41, 310, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("6f119f2e-09c7-449a-b4cc-801cf66d1b19"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 314, DateTimeKind.Local).AddTicks(4390), new DateTime(2022, 11, 24, 19, 43, 41, 314, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("82c15cda-87f5-4f8a-835e-26b8d45d2b03"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 314, DateTimeKind.Local).AddTicks(4383), new DateTime(2022, 11, 24, 19, 43, 41, 314, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c1e37ce0-4d59-48da-869f-b0dd59562f26"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 314, DateTimeKind.Local).AddTicks(4376), new DateTime(2022, 11, 24, 19, 43, 41, 314, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c503712d-6177-45c1-94d6-4be7cb00e4d8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 314, DateTimeKind.Local).AddTicks(3466), new DateTime(2022, 11, 24, 19, 43, 41, 314, DateTimeKind.Local).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("e94b5df4-379c-482d-99e0-10e35760d580"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 314, DateTimeKind.Local).AddTicks(4339), new DateTime(2022, 11, 24, 19, 43, 41, 314, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntasGrupos",
                keyColumn: "Id",
                keyValue: new Guid("b6da5dc4-2f08-4dc7-81df-8b1915bfab06"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 312, DateTimeKind.Local).AddTicks(6949), new DateTime(2022, 11, 24, 19, 43, 41, 312, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 305, DateTimeKind.Local).AddTicks(6033), new DateTime(2022, 11, 24, 19, 43, 41, 306, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("522eb3d9-e64d-4585-8776-e80f90cd9a0c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 306, DateTimeKind.Local).AddTicks(5491), new DateTime(2022, 11, 24, 19, 43, 41, 306, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("c959c0e8-24c9-4714-929f-5536bcd5dc0a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 24, 19, 43, 41, 306, DateTimeKind.Local).AddTicks(5546), new DateTime(2022, 11, 24, 19, 43, 41, 306, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.CreateIndex(
                name: "IX_ListaAmarela_DetentoId",
                table: "ListaAmarela",
                column: "DetentoId",
                unique: true,
                filter: "\"IsDeleted\"='0'");
        }
    }
}
