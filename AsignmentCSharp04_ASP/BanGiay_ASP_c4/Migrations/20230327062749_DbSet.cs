using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanGiay_ASP_c4.Migrations
{
    public partial class DbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    idColor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nameColor = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    statusColor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.idColor);
                });

            migrationBuilder.CreateTable(
                name: "Metarials",
                columns: table => new
                {
                    idMetarial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nameMetarial = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    statusMetarial = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metarials", x => x.idMetarial);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    idRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nameRole = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    statusRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.idRole);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    idProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idColor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idMetarial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nameProduct = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    nameColor = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    nameMetarial = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    priceProduct = table.Column<int>(type: "int", nullable: false),
                    availableQuantity = table.Column<int>(type: "int", nullable: false),
                    statusProduct = table.Column<int>(type: "int", nullable: false),
                    supplier = table.Column<string>(type: "nchar(100)", fixedLength: true, maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.idProduct);
                    table.ForeignKey(
                        name: "FK_Products_Colors_idColor",
                        column: x => x.idColor,
                        principalTable: "Colors",
                        principalColumn: "idColor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Metarials_idMetarial",
                        column: x => x.idMetarial,
                        principalTable: "Metarials",
                        principalColumn: "idMetarial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    idUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nameUser = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    emailUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    passwordUser = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    nameRole = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    statusUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.idUser);
                    table.ForeignKey(
                        name: "FK_Users_Roles_idRole",
                        column: x => x.idRole,
                        principalTable: "Roles",
                        principalColumn: "idRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    idBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    statusBill = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.idBill);
                    table.ForeignKey(
                        name: "FK_Bills_Users_idUser",
                        column: x => x.idUser,
                        principalTable: "Users",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    idUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    description = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    statusCart = table.Column<int>(type: "int", nullable: false),
                    UsersidUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.idUser);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UsersidUser",
                        column: x => x.UsersidUser,
                        principalTable: "Users",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    idBDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idBill = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    statusBDetail = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.idBDetail);
                    table.ForeignKey(
                        name: "FK_BillDetails_Bills_idBDetail",
                        column: x => x.idBDetail,
                        principalTable: "Bills",
                        principalColumn: "idBill",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_Products_idProduct",
                        column: x => x.idProduct,
                        principalTable: "Products",
                        principalColumn: "idProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CasrtDetail",
                columns: table => new
                {
                    idCDetail = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    idProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    statusCDetail = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CasrtDetail", x => x.idCDetail);
                    table.ForeignKey(
                        name: "FK_CasrtDetail_Carts_idUser",
                        column: x => x.idUser,
                        principalTable: "Carts",
                        principalColumn: "idUser",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CasrtDetail_Products_idProduct",
                        column: x => x.idProduct,
                        principalTable: "Products",
                        principalColumn: "idProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_idProduct",
                table: "BillDetails",
                column: "idProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_idUser",
                table: "Bills",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UsersidUser",
                table: "Carts",
                column: "UsersidUser");

            migrationBuilder.CreateIndex(
                name: "IX_CasrtDetail_idProduct",
                table: "CasrtDetail",
                column: "idProduct");

            migrationBuilder.CreateIndex(
                name: "IX_CasrtDetail_idUser",
                table: "CasrtDetail",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Products_idColor",
                table: "Products",
                column: "idColor");

            migrationBuilder.CreateIndex(
                name: "IX_Products_idMetarial",
                table: "Products",
                column: "idMetarial");

            migrationBuilder.CreateIndex(
                name: "IX_Users_idRole",
                table: "Users",
                column: "idRole");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropTable(
                name: "CasrtDetail");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Metarials");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
