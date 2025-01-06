using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebCRUDSample.Migrations
{
    /// <inheritdoc />
    public partial class SAP_ItemType_Mst_Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SAP_ItemType_Mst",
                columns: table => new
                {
                    pk_typeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMedicine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConsumable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reamrk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAP_ItemType_Mst", x => x.pk_typeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SAP_ItemType_Mst");
        }
    }
}
