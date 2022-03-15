using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserDataAccess.migration
{
    public partial class migrate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kisi_Iletisim_IletisimId",
                table: "Kisi");

            migrationBuilder.DropIndex(
                name: "IX_Kisi_IletisimId",
                table: "Kisi");

            migrationBuilder.DropColumn(
                name: "IletisimId",
                table: "Kisi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IletisimId",
                table: "Kisi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Kisi_IletisimId",
                table: "Kisi",
                column: "IletisimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kisi_Iletisim_IletisimId",
                table: "Kisi",
                column: "IletisimId",
                principalTable: "Iletisim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
