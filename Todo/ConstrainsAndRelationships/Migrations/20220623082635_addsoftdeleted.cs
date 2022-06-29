using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConstrainsAndRelationships.Migrations
{
    public partial class addsoftdeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SoftDeleted",
                table: "Students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "StartData",
                value: new DateTime(2022, 6, 23, 8, 26, 34, 636, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "StartData",
                value: new DateTime(2022, 6, 23, 8, 26, 34, 636, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "StartData",
                value: new DateTime(2022, 6, 23, 8, 26, 34, 636, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2022, 6, 23, 8, 26, 34, 636, DateTimeKind.Utc).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2022, 6, 24, 8, 26, 34, 636, DateTimeKind.Utc).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2022, 6, 25, 8, 26, 34, 636, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2022, 6, 26, 8, 26, 34, 636, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "EnrollmentDate",
                value: new DateTime(2022, 6, 23, 8, 26, 34, 636, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "EnrollmentDate",
                value: new DateTime(2022, 6, 23, 8, 26, 34, 636, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "EnrollmentDate",
                value: new DateTime(2022, 6, 23, 8, 26, 34, 636, DateTimeKind.Utc).AddTicks(2511));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoftDeleted",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "StartData",
                value: new DateTime(2022, 6, 22, 9, 39, 50, 331, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "StartData",
                value: new DateTime(2022, 6, 22, 9, 39, 50, 331, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "StartData",
                value: new DateTime(2022, 6, 22, 9, 39, 50, 331, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2022, 6, 22, 9, 39, 50, 331, DateTimeKind.Utc).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2022, 6, 23, 9, 39, 50, 331, DateTimeKind.Utc).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2022, 6, 24, 9, 39, 50, 331, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "InstructorId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2022, 6, 25, 9, 39, 50, 331, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "EnrollmentDate",
                value: new DateTime(2022, 6, 22, 9, 39, 50, 331, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "EnrollmentDate",
                value: new DateTime(2022, 6, 22, 9, 39, 50, 331, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "EnrollmentDate",
                value: new DateTime(2022, 6, 22, 9, 39, 50, 331, DateTimeKind.Utc).AddTicks(9848));
        }
    }
}
