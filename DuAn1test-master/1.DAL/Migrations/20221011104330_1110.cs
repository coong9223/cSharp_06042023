using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class _1110 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Point = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Producer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LinkImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Producer_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Producer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDRoles = table.Column<int>(type: "int", nullable: false),
                    LinkAnh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Roles_IDRoles",
                        column: x => x.IDRoles,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImportHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    dateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImportHistories_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImportHistories_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OderDetails",
                columns: table => new
                {
                    ProducID = table.Column<int>(type: "int", nullable: false),
                    OderID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OderDetails", x => new { x.OderID, x.ProducID });
                    table.ForeignKey(
                        name: "FK_OderDetails_Orders_OderID",
                        column: x => x.OderID,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OderDetails_Products_ProducID",
                        column: x => x.ProducID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Đồ ăn vặt" },
                    { 2, "Nước giải khát" },
                    { 3, "Đồ uống có cồn" },
                    { 4, "Nhu yếu phẩm" }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "ID", "Address", "Name", "Phone", "Point", "Sex" },
                values: new object[,]
                {
                    { 1, "n/a", "Khách vãng lai", "0", 0, true },
                    { 2, " 10 Minh Khai, Hà Nội", "Nguyễn Công Tiến", "0987654321", 10000, true },
                    { 3, " 69 Trịnh Văn Bô, Hà Nội", "Nguyễn Mạnh Thắng", "0987777777", 10000, true }
                });

            migrationBuilder.InsertData(
                table: "Producer",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Oishi" },
                    { 2, "Coca Cola" },
                    { 3, "Vodka" },
                    { 4, "Clear" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Quản lý" },
                    { 2, "Nhân viên" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Address", "Dob", "Email", "FullName", "IDRoles", "LinkAnh", "MaNV", "Password", "Phone", "Sex", "Status" },
                values: new object[,]
                {
                    { 1, "174 Phương Canh", new DateTime(2022, 10, 11, 17, 43, 29, 950, DateTimeKind.Local).AddTicks(6926), "manhman2806@gmail.com", "Bùi Thế Mạnh", 1, null, "NV1", "123", "0379200866", false, true },
                    { 2, "173 Phương Canh", new DateTime(2022, 10, 11, 17, 43, 29, 950, DateTimeKind.Local).AddTicks(6930), "khoanhph18902@gmail.com", "Nguyễn Hữu Khoa", 2, null, "NV2", "123", "0972439693", true, true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "DateCreated", "LinkImage", "MaSp", "Name", "Note", "OriginalPrice", "Price", "ProducerID", "Status", "Stock" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 10, 11, 17, 43, 29, 950, DateTimeKind.Local).AddTicks(6817), "", "01", "Bim bim Tôm Cay", "", 5000m, 6000m, 1, true, 10 },
                    { 2, 2, new DateTime(2022, 10, 11, 17, 43, 29, 950, DateTimeKind.Local).AddTicks(6835), "", "02", "Coca Cola", "", 10000m, 12000m, 2, true, 20 },
                    { 3, 3, new DateTime(2022, 10, 11, 17, 43, 29, 950, DateTimeKind.Local).AddTicks(6838), "", "03", "Absolut Vodka", "", 10000m, 60000m, 3, true, 50 },
                    { 4, 4, new DateTime(2022, 10, 11, 17, 43, 29, 950, DateTimeKind.Local).AddTicks(6841), "", "04", "Dầu gội Clear Men", "", 100000m, 150000m, 4, true, 5 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerID", "EmployeeID", "Note", "Status", "TotalPrice", "dateCreate" },
                values: new object[] { 1, 1, 1, null, true, 60000m, new DateTime(2022, 10, 11, 17, 43, 29, 950, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerID", "EmployeeID", "Note", "Status", "TotalPrice", "dateCreate" },
                values: new object[] { 2, 2, 2, null, true, 210000m, new DateTime(2022, 10, 11, 17, 43, 29, 950, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.InsertData(
                table: "OderDetails",
                columns: new[] { "OderID", "ProducID", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 6000m, 6 },
                    { 1, 2, 12000m, 2 },
                    { 2, 3, 60000m, 1 },
                    { 2, 4, 150000m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IDRoles",
                table: "Employees",
                column: "IDRoles");

            migrationBuilder.CreateIndex(
                name: "IX_ImportHistories_EmployeeID",
                table: "ImportHistories",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ImportHistories_ProductID",
                table: "ImportHistories",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OderDetails_ProducID",
                table: "OderDetails",
                column: "ProducID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeID",
                table: "Orders",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProducerID",
                table: "Products",
                column: "ProducerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImportHistories");

            migrationBuilder.DropTable(
                name: "OderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Producer");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
