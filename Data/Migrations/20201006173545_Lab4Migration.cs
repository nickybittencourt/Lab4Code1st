using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab4.Data.Migrations
{
    public partial class Lab4Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(nullable: false),
                    ProvinceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true),
                    Population = table.Column<int>(nullable: false),
                    ProvinceCode = table.Column<string>(nullable: true),
                    ProvinceCode1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_Province_ProvinceCode1",
                        column: x => x.ProvinceCode1,
                        principalTable: "Province",
                        principalColumn: "ProvinceCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CityName", "Population", "ProvinceCode", "ProvinceCode1" },
                values: new object[,]
                {
                    { 1, "Vancouver", 675218, "BC", null },
                    { 2, "Hope", 6181, "BC", null },
                    { 3, "Kelowna", 132084, "BC", null },
                    { 4, "Toronto", 2731571, "ON", null },
                    { 5, "Mississauga", 721599, "ON", null },
                    { 6, "Brampton", 593638, "ON", null },
                    { 7, "Winnipeg", 711925, "MB", null },
                    { 8, "Brandon", 48324, "MB", null },
                    { 9, "Steinbach", 14753, "MB", null },
                    { 10, "Calgary", 1237656, "AB", null },
                    { 11, "Edmonton", 1062643, "AB", null },
                    { 12, "Red Deer", 99718, "AB", null }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "BC", "British Columbia" },
                    { "ON", "Ontario" },
                    { "MB", "Manitoba" },
                    { "AB", "Alberta" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceCode1",
                table: "City",
                column: "ProvinceCode1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
