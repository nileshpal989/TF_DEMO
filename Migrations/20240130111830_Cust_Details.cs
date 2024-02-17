using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUDCORE.Migrations
{
    /// <inheritdoc />
    public partial class Cust_Details : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpDetails",
                columns: table => new
                {
                    Empid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMPNAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMPADDRESS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SALARY = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpDetails", x => x.Empid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpDetails");
        }
    }
}
