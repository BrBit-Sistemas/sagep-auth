﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Sagep.Infra.Data.Migrations
{
    public partial class CreateChangeCriticousColaboradorMap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_DetentoId",
                table: "Colaboradores");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_DetentoId",
                table: "Colaboradores",
                column: "DetentoId",
                filter: "\"IsDeleted\"='0'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_DetentoId",
                table: "Colaboradores");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_DetentoId",
                table: "Colaboradores",
                column: "DetentoId");
        }
    }
}
