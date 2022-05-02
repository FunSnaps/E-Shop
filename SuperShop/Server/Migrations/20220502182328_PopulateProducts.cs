using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperShop.Server.Migrations
{
    public partial class PopulateProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/6/25/1435245979235/047c9878-9845-473c-9635-5f32545746b0-1355x2040.jpeg?width=700&quality=85&auto=format&fit=max&s=606433bda33c8c27c5ebd7ba85900473", 9.99m, "The Hitchhiker's Guide to the Galaxy" },
                    { 2, "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment. Announced in 2019 as the successor to the PlayStation 4, the PS5 was released on November 12, 2020, in Australia, Japan, New Zealand, North America, and South Korea, with worldwide release following a week later. The PS5 is part of the ninth generation of video game consoles, along with Microsoft's Xbox Series X and Series S consoles, which were released in the same month.", "https://images.immediate.co.uk/production/volatile/sites/3/2020/08/playstation-5-77d37a0.jpg?quality=90&resize=980,654", 349.99m, "PlayStation 5" },
                    { 3, "The GeForce RTX™ 3080 Ti and RTX 3080 graphics cards deliver the ultra performance that gamers crave, powered by Ampere—NVIDIA’s 2nd gen RTX architecture. They are built with enhanced RT Cores and Tensor Cores, new streaming multiprocessors, and superfast G6X memory for an amazing gaming experience.", "https://sm.pcmag.com/t/pcmag_uk/news/n/nvidias-rt/nvidias-rtx-3070-surpasses-2080-ti-in-select-games_vns6.1920.jpg", 649.00m, "GEFORCE RTX 3080" },
                    { 4, "The GeForce RTX™ 3080 Ti and RTX 3080 graphics cards deliver the ultra performance that gamers crave, powered by Ampere—NVIDIA’s 2nd gen RTX architecture. They are built with enhanced RT Cores and Tensor Cores, new streaming multiprocessors, and superfast G6X memory for an amazing gaming experience.", "https://sm.pcmag.com/t/pcmag_uk/news/n/nvidias-rt/nvidias-rtx-3070-surpasses-2080-ti-in-select-games_vns6.1920.jpg", 649.00m, "GEFORCE RTX 3080" },
                    { 5, "The GeForce RTX™ 3080 Ti and RTX 3080 graphics cards deliver the ultra performance that gamers crave, powered by Ampere—NVIDIA’s 2nd gen RTX architecture. They are built with enhanced RT Cores and Tensor Cores, new streaming multiprocessors, and superfast G6X memory for an amazing gaming experience.", "https://sm.pcmag.com/t/pcmag_uk/news/n/nvidias-rt/nvidias-rtx-3070-surpasses-2080-ti-in-select-games_vns6.1920.jpg", 649.00m, "GEFORCE RTX 3080" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
