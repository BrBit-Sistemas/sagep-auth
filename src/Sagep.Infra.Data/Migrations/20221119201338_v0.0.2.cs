using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sagep.Infra.Data.Migrations
{
    public partial class v002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InfracoesAdministrativasDisciplinaresDetentos",
                columns: table => new
                {
                    InfracaoAdministrativaDisciplinarId = table.Column<Guid>(nullable: false),
                    DetentoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfracoesAdministrativasDisciplinaresDetentos", x => new { x.InfracaoAdministrativaDisciplinarId, x.DetentoId });
                    table.ForeignKey(
                        name: "FK_InfracoesAdministrativasDisciplinaresDetentos_Detentos_Dete~",
                        column: x => x.DetentoId,
                        principalTable: "Detentos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InfracoesAdministrativasDisciplinaresDetentos_InfracoesAdmi~",
                        column: x => x.InfracaoAdministrativaDisciplinarId,
                        principalTable: "InfracoesAdministrativasDisciplinares",
                        principalColumn: "Id");
                });

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
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 676, DateTimeKind.Local).AddTicks(5284), new DateTime(2022, 11, 19, 17, 13, 37, 676, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("0b0aac0b-805d-4ed5-b6cf-d7a03a4e77f1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 678, DateTimeKind.Local).AddTicks(3488), new DateTime(2022, 11, 19, 17, 13, 37, 678, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("1b82c38c-5fa9-484c-ba40-c2aa8183652e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 678, DateTimeKind.Local).AddTicks(2604), new DateTime(2022, 11, 19, 17, 13, 37, 678, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("38b52b32-6e69-438d-bce7-e9b75fda6cf3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 678, DateTimeKind.Local).AddTicks(3533), new DateTime(2022, 11, 19, 17, 13, 37, 678, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("e98df615-1bfd-4eb6-8f89-a91c3378db22"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 678, DateTimeKind.Local).AddTicks(3539), new DateTime(2022, 11, 19, 17, 13, 37, 678, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("f312ed91-b8a1-4a23-9c57-f24dac794089"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 678, DateTimeKind.Local).AddTicks(3526), new DateTime(2022, 11, 19, 17, 13, 37, 678, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("6f119f2e-09c7-449a-b4cc-801cf66d1b19"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 682, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 11, 19, 17, 13, 37, 682, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("82c15cda-87f5-4f8a-835e-26b8d45d2b03"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 682, DateTimeKind.Local).AddTicks(53), new DateTime(2022, 11, 19, 17, 13, 37, 682, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c1e37ce0-4d59-48da-869f-b0dd59562f26"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 682, DateTimeKind.Local).AddTicks(46), new DateTime(2022, 11, 19, 17, 13, 37, 682, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c503712d-6177-45c1-94d6-4be7cb00e4d8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 681, DateTimeKind.Local).AddTicks(8602), new DateTime(2022, 11, 19, 17, 13, 37, 681, DateTimeKind.Local).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("e94b5df4-379c-482d-99e0-10e35760d580"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 682, DateTimeKind.Local).AddTicks(11), new DateTime(2022, 11, 19, 17, 13, 37, 682, DateTimeKind.Local).AddTicks(19) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntasGrupos",
                keyColumn: "Id",
                keyValue: new Guid("b6da5dc4-2f08-4dc7-81df-8b1915bfab06"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 680, DateTimeKind.Local).AddTicks(2523), new DateTime(2022, 11, 19, 17, 13, 37, 680, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 673, DateTimeKind.Local).AddTicks(6308), new DateTime(2022, 11, 19, 17, 13, 37, 674, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("522eb3d9-e64d-4585-8776-e80f90cd9a0c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 674, DateTimeKind.Local).AddTicks(4744), new DateTime(2022, 11, 19, 17, 13, 37, 674, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("c959c0e8-24c9-4714-929f-5536bcd5dc0a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 17, 13, 37, 674, DateTimeKind.Local).AddTicks(4798), new DateTime(2022, 11, 19, 17, 13, 37, 674, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.CreateIndex(
                name: "IX_InfracoesAdministrativasDisciplinaresDetentos_DetentoId",
                table: "InfracoesAdministrativasDisciplinaresDetentos",
                column: "DetentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfracoesAdministrativasDisciplinaresDetentos");

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
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 837, DateTimeKind.Local).AddTicks(3245), new DateTime(2022, 11, 19, 14, 21, 40, 837, DateTimeKind.Local).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("0b0aac0b-805d-4ed5-b6cf-d7a03a4e77f1"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 839, DateTimeKind.Local).AddTicks(1716), new DateTime(2022, 11, 19, 14, 21, 40, 839, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("1b82c38c-5fa9-484c-ba40-c2aa8183652e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 839, DateTimeKind.Local).AddTicks(823), new DateTime(2022, 11, 19, 14, 21, 40, 839, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("38b52b32-6e69-438d-bce7-e9b75fda6cf3"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 839, DateTimeKind.Local).AddTicks(1751), new DateTime(2022, 11, 19, 14, 21, 40, 839, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("e98df615-1bfd-4eb6-8f89-a91c3378db22"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 839, DateTimeKind.Local).AddTicks(1758), new DateTime(2022, 11, 19, 14, 21, 40, 839, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraDicasEscritaDicas",
                keyColumn: "Id",
                keyValue: new Guid("f312ed91-b8a1-4a23-9c57-f24dac794089"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 839, DateTimeKind.Local).AddTicks(1745), new DateTime(2022, 11, 19, 14, 21, 40, 839, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("6f119f2e-09c7-449a-b4cc-801cf66d1b19"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 842, DateTimeKind.Local).AddTicks(8652), new DateTime(2022, 11, 19, 14, 21, 40, 842, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("82c15cda-87f5-4f8a-835e-26b8d45d2b03"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 842, DateTimeKind.Local).AddTicks(8646), new DateTime(2022, 11, 19, 14, 21, 40, 842, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c1e37ce0-4d59-48da-869f-b0dd59562f26"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 842, DateTimeKind.Local).AddTicks(8639), new DateTime(2022, 11, 19, 14, 21, 40, 842, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("c503712d-6177-45c1-94d6-4be7cb00e4d8"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 842, DateTimeKind.Local).AddTicks(7700), new DateTime(2022, 11, 19, 14, 21, 40, 842, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntas",
                keyColumn: "Id",
                keyValue: new Guid("e94b5df4-379c-482d-99e0-10e35760d580"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 842, DateTimeKind.Local).AddTicks(8576), new DateTime(2022, 11, 19, 14, 21, 40, 842, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "FormularioLeituraPerguntasGrupos",
                keyColumn: "Id",
                keyValue: new Guid("b6da5dc4-2f08-4dc7-81df-8b1915bfab06"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 841, DateTimeKind.Local).AddTicks(1559), new DateTime(2022, 11, 19, 14, 21, 40, 841, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("206c645a-2966-4ad9-19a3-dced7c201bc4"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 834, DateTimeKind.Local).AddTicks(3058), new DateTime(2022, 11, 19, 14, 21, 40, 835, DateTimeKind.Local).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("522eb3d9-e64d-4585-8776-e80f90cd9a0c"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 835, DateTimeKind.Local).AddTicks(2221), new DateTime(2022, 11, 19, 14, 21, 40, 835, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Tenants",
                keyColumn: "Id",
                keyValue: new Guid("c959c0e8-24c9-4714-929f-5536bcd5dc0a"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 11, 19, 14, 21, 40, 835, DateTimeKind.Local).AddTicks(2279), new DateTime(2022, 11, 19, 14, 21, 40, 835, DateTimeKind.Local).AddTicks(2282) });
        }
    }
}
