using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class addinitialentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibraryBranch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Telephone = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    OpenDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryBranch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fees = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BranchHours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DayOfWeek = table.Column<int>(nullable: false),
                    OpenTime = table.Column<int>(nullable: false),
                    CloseTime = table.Column<int>(nullable: false),
                    BranchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BranchHours_LibraryBranch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "LibraryBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patron",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    TelephoneNumber = table.Column<string>(maxLength: 50, nullable: true),
                    LibraryCardId = table.Column<int>(nullable: true),
                    HomeLibraryBranchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patron", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patron_LibraryBranch_HomeLibraryBranchId",
                        column: x => x.HomeLibraryBranchId,
                        principalTable: "LibraryBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patron_LibraryCard_LibraryCardId",
                        column: x => x.LibraryCardId,
                        principalTable: "LibraryCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LibraryAssest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    NumberOfCopies = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    ISBN = table.Column<string>(maxLength: 50, nullable: true),
                    Author = table.Column<string>(maxLength: 50, nullable: true),
                    DeweyIndex = table.Column<string>(maxLength: 50, nullable: true),
                    Director = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryAssest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryAssest_LibraryBranch_LocationId",
                        column: x => x.LocationId,
                        principalTable: "LibraryBranch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LibraryAssest_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Since = table.Column<DateTime>(type: "datetime", nullable: false),
                    Until = table.Column<DateTime>(type: "datetime", nullable: false),
                    LibraryAssetId = table.Column<int>(nullable: false),
                    LibraryCardId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkout_LibraryAssest_LibraryAssetId",
                        column: x => x.LibraryAssetId,
                        principalTable: "LibraryAssest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkout_LibraryCard_LibraryCardId",
                        column: x => x.LibraryCardId,
                        principalTable: "LibraryCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckoutHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CheckedOut = table.Column<DateTime>(type: "datetime", nullable: false),
                    CheckedIn = table.Column<DateTime>(type: "datetime", nullable: true),
                    LibraryAssetId = table.Column<int>(nullable: false),
                    LibraryCardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckoutHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckoutHistory_LibraryAssest_LibraryAssetId",
                        column: x => x.LibraryAssetId,
                        principalTable: "LibraryAssest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckoutHistory_LibraryCard_LibraryCardId",
                        column: x => x.LibraryCardId,
                        principalTable: "LibraryCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hold",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    HoldPlaced = table.Column<DateTime>(type: "datetime", nullable: false),
                    LibraryAssetId = table.Column<int>(nullable: true),
                    LibraryCardId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hold", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hold_LibraryAssest_LibraryAssetId",
                        column: x => x.LibraryAssetId,
                        principalTable: "LibraryAssest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hold_LibraryCard_LibraryCardId",
                        column: x => x.LibraryCardId,
                        principalTable: "LibraryCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchHours_BranchId",
                table: "BranchHours",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_LibraryAssetId",
                table: "Checkout",
                column: "LibraryAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkout_LibraryCardId",
                table: "Checkout",
                column: "LibraryCardId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistory_LibraryAssetId",
                table: "CheckoutHistory",
                column: "LibraryAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckoutHistory_LibraryCardId",
                table: "CheckoutHistory",
                column: "LibraryCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Hold_LibraryAssetId",
                table: "Hold",
                column: "LibraryAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_Hold_LibraryCardId",
                table: "Hold",
                column: "LibraryCardId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAssest_LocationId",
                table: "LibraryAssest",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAssest_StatusId",
                table: "LibraryAssest",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Patron_HomeLibraryBranchId",
                table: "Patron",
                column: "HomeLibraryBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Patron_LibraryCardId",
                table: "Patron",
                column: "LibraryCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchHours");

            migrationBuilder.DropTable(
                name: "Checkout");

            migrationBuilder.DropTable(
                name: "CheckoutHistory");

            migrationBuilder.DropTable(
                name: "Hold");

            migrationBuilder.DropTable(
                name: "Patron");

            migrationBuilder.DropTable(
                name: "LibraryAssest");

            migrationBuilder.DropTable(
                name: "LibraryCard");

            migrationBuilder.DropTable(
                name: "LibraryBranch");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
