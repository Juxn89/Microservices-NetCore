using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.Persitence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Product item description #1", "Product item name #1", 581m },
                    { 2, "Product item description #2", "Product item name #2", 589m },
                    { 3, "Product item description #3", "Product item name #3", 855m },
                    { 4, "Product item description #4", "Product item name #4", 852m },
                    { 5, "Product item description #5", "Product item name #5", 839m },
                    { 6, "Product item description #6", "Product item name #6", 520m },
                    { 7, "Product item description #7", "Product item name #7", 638m },
                    { 8, "Product item description #8", "Product item name #8", 602m },
                    { 9, "Product item description #9", "Product item name #9", 878m },
                    { 10, "Product item description #10", "Product item name #10", 826m },
                    { 11, "Product item description #11", "Product item name #11", 646m },
                    { 12, "Product item description #12", "Product item name #12", 620m },
                    { 13, "Product item description #13", "Product item name #13", 559m },
                    { 14, "Product item description #14", "Product item name #14", 309m },
                    { 15, "Product item description #15", "Product item name #15", 833m },
                    { 16, "Product item description #16", "Product item name #16", 959m },
                    { 17, "Product item description #17", "Product item name #17", 982m },
                    { 18, "Product item description #18", "Product item name #18", 474m },
                    { 19, "Product item description #19", "Product item name #19", 922m },
                    { 20, "Product item description #20", "Product item name #20", 247m },
                    { 21, "Product item description #21", "Product item name #21", 656m },
                    { 22, "Product item description #22", "Product item name #22", 607m },
                    { 23, "Product item description #23", "Product item name #23", 222m },
                    { 24, "Product item description #24", "Product item name #24", 941m },
                    { 25, "Product item description #25", "Product item name #25", 572m },
                    { 26, "Product item description #26", "Product item name #26", 606m },
                    { 27, "Product item description #27", "Product item name #27", 381m },
                    { 28, "Product item description #28", "Product item name #28", 512m },
                    { 29, "Product item description #29", "Product item name #29", 929m },
                    { 30, "Product item description #30", "Product item name #30", 674m },
                    { 31, "Product item description #31", "Product item name #31", 771m },
                    { 32, "Product item description #32", "Product item name #32", 231m },
                    { 33, "Product item description #33", "Product item name #33", 154m },
                    { 34, "Product item description #34", "Product item name #34", 338m },
                    { 35, "Product item description #35", "Product item name #35", 590m },
                    { 36, "Product item description #36", "Product item name #36", 710m },
                    { 37, "Product item description #37", "Product item name #37", 800m },
                    { 38, "Product item description #38", "Product item name #38", 535m },
                    { 39, "Product item description #39", "Product item name #39", 118m },
                    { 40, "Product item description #40", "Product item name #40", 731m },
                    { 41, "Product item description #41", "Product item name #41", 726m },
                    { 42, "Product item description #42", "Product item name #42", 720m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 43, "Product item description #43", "Product item name #43", 899m },
                    { 44, "Product item description #44", "Product item name #44", 437m },
                    { 45, "Product item description #45", "Product item name #45", 532m },
                    { 46, "Product item description #46", "Product item name #46", 507m },
                    { 47, "Product item description #47", "Product item name #47", 297m },
                    { 48, "Product item description #48", "Product item name #48", 523m },
                    { 49, "Product item description #49", "Product item name #49", 695m },
                    { 50, "Product item description #50", "Product item name #50", 833m },
                    { 51, "Product item description #51", "Product item name #51", 119m },
                    { 52, "Product item description #52", "Product item name #52", 627m },
                    { 53, "Product item description #53", "Product item name #53", 885m },
                    { 54, "Product item description #54", "Product item name #54", 397m },
                    { 55, "Product item description #55", "Product item name #55", 345m },
                    { 56, "Product item description #56", "Product item name #56", 336m },
                    { 57, "Product item description #57", "Product item name #57", 339m },
                    { 58, "Product item description #58", "Product item name #58", 820m },
                    { 59, "Product item description #59", "Product item name #59", 443m },
                    { 60, "Product item description #60", "Product item name #60", 152m },
                    { 61, "Product item description #61", "Product item name #61", 804m },
                    { 62, "Product item description #62", "Product item name #62", 497m },
                    { 63, "Product item description #63", "Product item name #63", 799m },
                    { 64, "Product item description #64", "Product item name #64", 290m },
                    { 65, "Product item description #65", "Product item name #65", 724m },
                    { 66, "Product item description #66", "Product item name #66", 798m },
                    { 67, "Product item description #67", "Product item name #67", 405m },
                    { 68, "Product item description #68", "Product item name #68", 852m },
                    { 69, "Product item description #69", "Product item name #69", 624m },
                    { 70, "Product item description #70", "Product item name #70", 776m },
                    { 71, "Product item description #71", "Product item name #71", 660m },
                    { 72, "Product item description #72", "Product item name #72", 155m },
                    { 73, "Product item description #73", "Product item name #73", 866m },
                    { 74, "Product item description #74", "Product item name #74", 688m },
                    { 75, "Product item description #75", "Product item name #75", 503m },
                    { 76, "Product item description #76", "Product item name #76", 811m },
                    { 77, "Product item description #77", "Product item name #77", 155m },
                    { 78, "Product item description #78", "Product item name #78", 117m },
                    { 79, "Product item description #79", "Product item name #79", 618m },
                    { 80, "Product item description #80", "Product item name #80", 306m },
                    { 81, "Product item description #81", "Product item name #81", 200m },
                    { 82, "Product item description #82", "Product item name #82", 381m },
                    { 83, "Product item description #83", "Product item name #83", 377m },
                    { 84, "Product item description #84", "Product item name #84", 440m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 85, "Product item description #85", "Product item name #85", 469m },
                    { 86, "Product item description #86", "Product item name #86", 954m },
                    { 87, "Product item description #87", "Product item name #87", 866m },
                    { 88, "Product item description #88", "Product item name #88", 285m },
                    { 89, "Product item description #89", "Product item name #89", 887m },
                    { 90, "Product item description #90", "Product item name #90", 507m },
                    { 91, "Product item description #91", "Product item name #91", 119m },
                    { 92, "Product item description #92", "Product item name #92", 869m },
                    { 93, "Product item description #93", "Product item name #93", 652m },
                    { 94, "Product item description #94", "Product item name #94", 340m },
                    { 95, "Product item description #95", "Product item name #95", 954m },
                    { 96, "Product item description #96", "Product item name #96", 169m },
                    { 97, "Product item description #97", "Product item name #97", 635m },
                    { 98, "Product item description #98", "Product item name #98", 885m },
                    { 99, "Product item description #99", "Product item name #99", 712m },
                    { 100, "Product item description #100", "Product item name #100", 224m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
