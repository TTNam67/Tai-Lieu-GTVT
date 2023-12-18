using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineClothingShop.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Categories",
                columns: table => new
                {
                    CatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Thumb = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Categories", x => x.CatID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NameWithType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PathWithType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ParentCode = table.Column<int>(type: "int", nullable: true),
                    Levels = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "tb_TransactStatus",
                columns: table => new
                {
                    TransactStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_TransactStatus", x => x.TransactStatusID);
                });

            migrationBuilder.CreateTable(
                name: "tb_Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ShortDesc = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    ThumbImg = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SingleImg = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DescImg = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: true),
                    BestSellers = table.Column<bool>(type: "bit", nullable: true),
                    HomeFlag = table.Column<bool>(type: "bit", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    UnitsInStock = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Products_1", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_tb_Products_tb_Categories",
                        column: x => x.CatID,
                        principalTable: "tb_Categories",
                        principalColumn: "CatID");
                });

            migrationBuilder.CreateTable(
                name: "tb_Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "nchar(150)", fixedLength: true, maxLength: 150, nullable: true),
                    Phone = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    LocationID = table.Column<int>(type: "int", nullable: true),
                    District = table.Column<int>(type: "int", nullable: true),
                    Ward = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Salt = table.Column<string>(type: "nchar(8)", fixedLength: true, maxLength: 8, nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Customers", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_tb_Customers_tb_Locations",
                        column: x => x.LocationID,
                        principalTable: "tb_Locations",
                        principalColumn: "LocationID");
                });

            migrationBuilder.CreateTable(
                name: "tb_Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ShipDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TransactStatusID = table.Column<int>(type: "int", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    Paid = table.Column<bool>(type: "bit", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PaymentID = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_tb_Orders_tb_Customers",
                        column: x => x.CustomerID,
                        principalTable: "tb_Customers",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_tb_Orders_tb_TransactStatus",
                        column: x => x.TransactStatusID,
                        principalTable: "tb_TransactStatus",
                        principalColumn: "TransactStatusID");
                });

            migrationBuilder.CreateTable(
                name: "tb_OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    OrderNumber = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<int>(type: "int", nullable: true),
                    ShipDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_tb_OrderDetails_tb_Orders",
                        column: x => x.OrderID,
                        principalTable: "tb_Orders",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK_tb_OrderDetails_tb_Products",
                        column: x => x.ProductID,
                        principalTable: "tb_Products",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Customers_LocationID",
                table: "tb_Customers",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_OrderDetails_OrderID",
                table: "tb_OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_OrderDetails_ProductID",
                table: "tb_OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Orders_CustomerID",
                table: "tb_Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Orders_TransactStatusID",
                table: "tb_Orders",
                column: "TransactStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Products_CatID",
                table: "tb_Products",
                column: "CatID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_OrderDetails");

            migrationBuilder.DropTable(
                name: "tb_Orders");

            migrationBuilder.DropTable(
                name: "tb_Products");

            migrationBuilder.DropTable(
                name: "tb_Customers");

            migrationBuilder.DropTable(
                name: "tb_TransactStatus");

            migrationBuilder.DropTable(
                name: "tb_Categories");

            migrationBuilder.DropTable(
                name: "tb_Locations");
        }
    }
}
