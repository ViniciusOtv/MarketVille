using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarktVille.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "SubCategoryId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "SmallImage");

            migrationBuilder.RenameColumn(
                name: "nickName",
                table: "Locations",
                newName: "NickName");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Suppliers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Suppliers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CoverImage",
                table: "Stores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CostPrice",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LargeImage",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MediumImage",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SellingPrice",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Voltage",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageLocality",
                table: "Locations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.SubCategoryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "CoverImage",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CostPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LargeImage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MediumImage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SellingPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageLocality",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "SmallImage",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "NickName",
                table: "Locations",
                newName: "nickName");
        }
    }
}
