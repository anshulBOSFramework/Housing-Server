using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Housing_Server.Migrations
{
    public partial class dbfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlatNo = table.Column<int>(type: "int", nullable: true),
                    FloorNo = table.Column<int>(type: "int", nullable: false),
                    TotalFloors = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyBuys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PropertyCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContructionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyBhk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyBathroom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyBalcony = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyFurniture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyCoveredParking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyOpenParking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyCost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyMaintenanceCost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyCarpetArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyPossessionDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyBuys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyBuys_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyPGs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PropertyCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyBeds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyPGType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertySuited = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyMeals = table.Column<bool>(type: "bit", nullable: false),
                    PropertyNotice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyLock = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyCommonArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyManaged = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyIsManaged = table.Column<bool>(type: "bit", nullable: true),
                    IsNonVeg = table.Column<bool>(type: "bit", nullable: false),
                    IsOppositeSex = table.Column<bool>(type: "bit", nullable: false),
                    IsAnyTimeAllowed = table.Column<bool>(type: "bit", nullable: false),
                    IsVisitorAllowed = table.Column<bool>(type: "bit", nullable: false),
                    IsGuardianAllowed = table.Column<bool>(type: "bit", nullable: false),
                    IsDrinkingAllowed = table.Column<bool>(type: "bit", nullable: false),
                    IsSmokingAllowed = table.Column<bool>(type: "bit", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyPGs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyPGs_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PropertyRents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PropertyCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyAge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyBhk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyBathroom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyBalcony = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyFurniture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyCoveredParking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyOpenParking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyAvailable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyMonthlyRent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyMaintenanceCost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyDeposit = table.Column<bool>(type: "bit", nullable: false),
                    PropertyArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyCarpetArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyTenantType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyRents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyRents_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyBuys_AddressId",
                table: "PropertyBuys",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyPGs_AddressId",
                table: "PropertyPGs",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyRents_AddressId",
                table: "PropertyRents",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyBuys");

            migrationBuilder.DropTable(
                name: "PropertyPGs");

            migrationBuilder.DropTable(
                name: "PropertyRents");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
