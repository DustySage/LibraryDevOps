using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class addmodels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_AspNetUsers_PatronId1",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_PatronId1",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_PatronId1",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Loans_PatronId1",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "PatronId1",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "PatronId1",
                table: "Loans");

            migrationBuilder.AlterColumn<string>(
                name: "PatronId",
                table: "Reservations",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "PatronId",
                table: "Loans",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PatronId",
                table: "Reservations",
                column: "PatronId");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_PatronId",
                table: "Loans",
                column: "PatronId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_AspNetUsers_PatronId",
                table: "Loans",
                column: "PatronId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_PatronId",
                table: "Reservations",
                column: "PatronId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_AspNetUsers_PatronId",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_PatronId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_PatronId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Loans_PatronId",
                table: "Loans");

            migrationBuilder.AlterColumn<int>(
                name: "PatronId",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "PatronId1",
                table: "Reservations",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "PatronId",
                table: "Loans",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "PatronId1",
                table: "Loans",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PatronId1",
                table: "Reservations",
                column: "PatronId1");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_PatronId1",
                table: "Loans",
                column: "PatronId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_AspNetUsers_PatronId1",
                table: "Loans",
                column: "PatronId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_PatronId1",
                table: "Reservations",
                column: "PatronId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
