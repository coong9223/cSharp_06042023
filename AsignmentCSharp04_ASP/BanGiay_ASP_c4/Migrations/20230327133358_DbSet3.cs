using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanGiay_ASP_c4.Migrations
{
    public partial class DbSet3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Bills_idBDetail",
                table: "BillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CasrtDetail_Carts_idUser",
                table: "CasrtDetail");

            migrationBuilder.RenameColumn(
                name: "idUser",
                table: "CasrtDetail",
                newName: "idUserFK");

            migrationBuilder.RenameIndex(
                name: "IX_CasrtDetail_idUser",
                table: "CasrtDetail",
                newName: "IX_CasrtDetail_idUserFK");

            migrationBuilder.RenameColumn(
                name: "idUser",
                table: "Carts",
                newName: "idUserFK");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_idBill",
                table: "BillDetails",
                column: "idBill");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Bills_idBill",
                table: "BillDetails",
                column: "idBill",
                principalTable: "Bills",
                principalColumn: "idBill",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CasrtDetail_Carts_idUserFK",
                table: "CasrtDetail",
                column: "idUserFK",
                principalTable: "Carts",
                principalColumn: "idUserFK",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_Bills_idBill",
                table: "BillDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CasrtDetail_Carts_idUserFK",
                table: "CasrtDetail");

            migrationBuilder.DropIndex(
                name: "IX_BillDetails_idBill",
                table: "BillDetails");

            migrationBuilder.RenameColumn(
                name: "idUserFK",
                table: "CasrtDetail",
                newName: "idUser");

            migrationBuilder.RenameIndex(
                name: "IX_CasrtDetail_idUserFK",
                table: "CasrtDetail",
                newName: "IX_CasrtDetail_idUser");

            migrationBuilder.RenameColumn(
                name: "idUserFK",
                table: "Carts",
                newName: "idUser");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_Bills_idBDetail",
                table: "BillDetails",
                column: "idBDetail",
                principalTable: "Bills",
                principalColumn: "idBill",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CasrtDetail_Carts_idUser",
                table: "CasrtDetail",
                column: "idUser",
                principalTable: "Carts",
                principalColumn: "idUser",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
