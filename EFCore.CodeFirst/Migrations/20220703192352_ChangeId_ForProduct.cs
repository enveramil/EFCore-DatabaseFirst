using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.CodeFirst.Migrations
{
    public partial class ChangeId_ForProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price2",
                schema: "productssDbb",
                table: "ProductsDBB",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name2",
                schema: "productssDbb",
                table: "ProductsDBB",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "productssDbb",
                table: "ProductsDBB",
                newName: "Product_Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                schema: "productssDbb",
                table: "ProductsDBB",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "productssDbb",
                table: "ProductsDBB",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "Product_Id",
                schema: "productssDbb",
                table: "ProductsDBB",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("Relational:ColumnOrder", 1)
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                schema: "productssDbb",
                table: "ProductsDBB",
                newName: "price2");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "productssDbb",
                table: "ProductsDBB",
                newName: "name2");

            migrationBuilder.RenameColumn(
                name: "Product_Id",
                schema: "productssDbb",
                table: "ProductsDBB",
                newName: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "price2",
                schema: "productssDbb",
                table: "ProductsDBB",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "name2",
                schema: "productssDbb",
                table: "ProductsDBB",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "productssDbb",
                table: "ProductsDBB",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1)
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
