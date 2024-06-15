using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace stock_market_data.Migrations
{
    public partial class UpdateTradeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TradeDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "date", nullable: false),
                    trade_code = table.Column<string>(type: "varchar(50)", nullable: false),
                    hight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    low = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    open = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    close = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    volume = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeDatas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TradeDatas");
        }
    }
}
