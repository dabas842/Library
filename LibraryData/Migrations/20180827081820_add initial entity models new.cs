using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class addinitialentitymodelsnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchHours_LibraryBranch_BranchId",
                table: "BranchHours");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkout_LibraryAssest_LibraryAssetId",
                table: "Checkout");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkout_LibraryCard_LibraryCardId",
                table: "Checkout");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistory_LibraryAssest_LibraryAssetId",
                table: "CheckoutHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistory_LibraryCard_LibraryCardId",
                table: "CheckoutHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_Hold_LibraryAssest_LibraryAssetId",
                table: "Hold");

            migrationBuilder.DropForeignKey(
                name: "FK_Hold_LibraryCard_LibraryCardId",
                table: "Hold");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssest_LibraryBranch_LocationId",
                table: "LibraryAssest");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssest_Status_StatusId",
                table: "LibraryAssest");

            migrationBuilder.DropForeignKey(
                name: "FK_Patron_LibraryBranch_HomeLibraryBranchId",
                table: "Patron");

            migrationBuilder.DropForeignKey(
                name: "FK_Patron_LibraryCard_LibraryCardId",
                table: "Patron");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Status",
                table: "Status");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patron",
                table: "Patron");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryCard",
                table: "LibraryCard");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryBranch",
                table: "LibraryBranch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryAssest",
                table: "LibraryAssest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hold",
                table: "Hold");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckoutHistory",
                table: "CheckoutHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Checkout",
                table: "Checkout");

            migrationBuilder.RenameTable(
                name: "Status",
                newName: "Statuses");

            migrationBuilder.RenameTable(
                name: "Patron",
                newName: "Patrons");

            migrationBuilder.RenameTable(
                name: "LibraryCard",
                newName: "LibraryCards");

            migrationBuilder.RenameTable(
                name: "LibraryBranch",
                newName: "LibraryBranches");

            migrationBuilder.RenameTable(
                name: "LibraryAssest",
                newName: "LibraryAssets");

            migrationBuilder.RenameTable(
                name: "Hold",
                newName: "Holds");

            migrationBuilder.RenameTable(
                name: "CheckoutHistory",
                newName: "CheckoutHistories");

            migrationBuilder.RenameTable(
                name: "Checkout",
                newName: "Checkouts");

            migrationBuilder.RenameIndex(
                name: "IX_Patron_LibraryCardId",
                table: "Patrons",
                newName: "IX_Patrons_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Patron_HomeLibraryBranchId",
                table: "Patrons",
                newName: "IX_Patrons_HomeLibraryBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryAssest_StatusId",
                table: "LibraryAssets",
                newName: "IX_LibraryAssets_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryAssest_LocationId",
                table: "LibraryAssets",
                newName: "IX_LibraryAssets_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Hold_LibraryCardId",
                table: "Holds",
                newName: "IX_Holds_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Hold_LibraryAssetId",
                table: "Holds",
                newName: "IX_Holds_LibraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistory_LibraryCardId",
                table: "CheckoutHistories",
                newName: "IX_CheckoutHistories_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistory_LibraryAssetId",
                table: "CheckoutHistories",
                newName: "IX_CheckoutHistories_LibraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_Checkout_LibraryCardId",
                table: "Checkouts",
                newName: "IX_Checkouts_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Checkout_LibraryAssetId",
                table: "Checkouts",
                newName: "IX_Checkouts_LibraryAssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryCards",
                table: "LibraryCards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryBranches",
                table: "LibraryBranches",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryAssets",
                table: "LibraryAssets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Holds",
                table: "Holds",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckoutHistories",
                table: "CheckoutHistories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Checkouts",
                table: "Checkouts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchHours_LibraryBranches_BranchId",
                table: "BranchHours",
                column: "BranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_LibraryAssetId",
                table: "CheckoutHistories",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryCards_LibraryCardId",
                table: "CheckoutHistories",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_LibraryAssets_LibraryAssetId",
                table: "Checkouts",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_LibraryCards_LibraryCardId",
                table: "Checkouts",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetId",
                table: "Holds",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_LibraryCards_LibraryCardId",
                table: "Holds",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LocationId",
                table: "LibraryAssets",
                column: "LocationId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssets_Statuses_StatusId",
                table: "LibraryAssets",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchHours_LibraryBranches_BranchId",
                table: "BranchHours");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_LibraryAssetId",
                table: "CheckoutHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryCards_LibraryCardId",
                table: "CheckoutHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_LibraryAssets_LibraryAssetId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_LibraryCards_LibraryCardId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetId",
                table: "Holds");

            migrationBuilder.DropForeignKey(
                name: "FK_Holds_LibraryCards_LibraryCardId",
                table: "Holds");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_LibraryBranches_LocationId",
                table: "LibraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_LibraryAssets_Statuses_StatusId",
                table: "LibraryAssets");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Statuses",
                table: "Statuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryCards",
                table: "LibraryCards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryBranches",
                table: "LibraryBranches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryAssets",
                table: "LibraryAssets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Holds",
                table: "Holds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Checkouts",
                table: "Checkouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckoutHistories",
                table: "CheckoutHistories");

            migrationBuilder.RenameTable(
                name: "Statuses",
                newName: "Status");

            migrationBuilder.RenameTable(
                name: "Patrons",
                newName: "Patron");

            migrationBuilder.RenameTable(
                name: "LibraryCards",
                newName: "LibraryCard");

            migrationBuilder.RenameTable(
                name: "LibraryBranches",
                newName: "LibraryBranch");

            migrationBuilder.RenameTable(
                name: "LibraryAssets",
                newName: "LibraryAssest");

            migrationBuilder.RenameTable(
                name: "Holds",
                newName: "Hold");

            migrationBuilder.RenameTable(
                name: "Checkouts",
                newName: "Checkout");

            migrationBuilder.RenameTable(
                name: "CheckoutHistories",
                newName: "CheckoutHistory");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patron",
                newName: "IX_Patron_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_HomeLibraryBranchId",
                table: "Patron",
                newName: "IX_Patron_HomeLibraryBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryAssets_StatusId",
                table: "LibraryAssest",
                newName: "IX_LibraryAssest_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryAssets_LocationId",
                table: "LibraryAssest",
                newName: "IX_LibraryAssest_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Holds_LibraryCardId",
                table: "Hold",
                newName: "IX_Hold_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Holds_LibraryAssetId",
                table: "Hold",
                newName: "IX_Hold_LibraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_Checkouts_LibraryCardId",
                table: "Checkout",
                newName: "IX_Checkout_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_Checkouts_LibraryAssetId",
                table: "Checkout",
                newName: "IX_Checkout_LibraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistories_LibraryCardId",
                table: "CheckoutHistory",
                newName: "IX_CheckoutHistory_LibraryCardId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistories_LibraryAssetId",
                table: "CheckoutHistory",
                newName: "IX_CheckoutHistory_LibraryAssetId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Status",
                table: "Status",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patron",
                table: "Patron",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryCard",
                table: "LibraryCard",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryBranch",
                table: "LibraryBranch",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryAssest",
                table: "LibraryAssest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hold",
                table: "Hold",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Checkout",
                table: "Checkout",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckoutHistory",
                table: "CheckoutHistory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchHours_LibraryBranch_BranchId",
                table: "BranchHours",
                column: "BranchId",
                principalTable: "LibraryBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkout_LibraryAssest_LibraryAssetId",
                table: "Checkout",
                column: "LibraryAssetId",
                principalTable: "LibraryAssest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkout_LibraryCard_LibraryCardId",
                table: "Checkout",
                column: "LibraryCardId",
                principalTable: "LibraryCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistory_LibraryAssest_LibraryAssetId",
                table: "CheckoutHistory",
                column: "LibraryAssetId",
                principalTable: "LibraryAssest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistory_LibraryCard_LibraryCardId",
                table: "CheckoutHistory",
                column: "LibraryCardId",
                principalTable: "LibraryCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hold_LibraryAssest_LibraryAssetId",
                table: "Hold",
                column: "LibraryAssetId",
                principalTable: "LibraryAssest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hold_LibraryCard_LibraryCardId",
                table: "Hold",
                column: "LibraryCardId",
                principalTable: "LibraryCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssest_LibraryBranch_LocationId",
                table: "LibraryAssest",
                column: "LocationId",
                principalTable: "LibraryBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryAssest_Status_StatusId",
                table: "LibraryAssest",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patron_LibraryBranch_HomeLibraryBranchId",
                table: "Patron",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patron_LibraryCard_LibraryCardId",
                table: "Patron",
                column: "LibraryCardId",
                principalTable: "LibraryCard",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
