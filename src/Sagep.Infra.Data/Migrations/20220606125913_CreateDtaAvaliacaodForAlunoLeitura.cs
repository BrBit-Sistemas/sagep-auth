﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sagep.Infra.Data.Migrations
{
    public partial class CreateDtaAvaliacaodForAlunoLeitura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataAvaliacao",
                table: "AlunosLeituras",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAvaliacao",
                table: "AlunosLeituras");
        }
    }
}
