using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TrainingProgramModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPrograms_Employees_TrainerID",
                table: "TrainingPrograms");

            migrationBuilder.AlterColumn<Guid>(
                name: "TrainerID",
                table: "TrainingPrograms",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPrograms_Employees_TrainerID",
                table: "TrainingPrograms",
                column: "TrainerID",
                principalTable: "Employees",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingPrograms_Employees_TrainerID",
                table: "TrainingPrograms");

            migrationBuilder.AlterColumn<Guid>(
                name: "TrainerID",
                table: "TrainingPrograms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingPrograms_Employees_TrainerID",
                table: "TrainingPrograms",
                column: "TrainerID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
