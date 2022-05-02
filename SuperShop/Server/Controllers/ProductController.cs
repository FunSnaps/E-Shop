using Microsoft.AspNetCore.Mvc;

namespace SuperShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext dataContext;

        /*protected static List<Product> Products { get; set; } = new List<Product>
{
new Product
{
Id = 1,
Title = "The Hitchhiker's Guide to the Galaxy",
Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
ImageUrl = "https://i.guim.co.uk/img/static/sys-images/Guardian/Pix/pictures/2015/6/25/1435245979235/047c9878-9845-473c-9635-5f32545746b0-1355x2040.jpeg?width=700&quality=85&auto=format&fit=max&s=606433bda33c8c27c5ebd7ba85900473",
Price = 9.99m, // m is for Moolah!
},
new Product
{
Id = 2,
Title = "PlayStation 5",
Description = "The PlayStation 5 (PS5) is a home video game console developed by Sony Interactive Entertainment. Announced in 2019 as the successor to the PlayStation 4, the PS5 was released on November 12, 2020, in Australia, Japan, New Zealand, North America, and South Korea, with worldwide release following a week later. The PS5 is part of the ninth generation of video game consoles, along with Microsoft's Xbox Series X and Series S consoles, which were released in the same month.",
ImageUrl = "https://images.immediate.co.uk/production/volatile/sites/3/2020/08/playstation-5-77d37a0.jpg?quality=90&resize=980,654",
Price = 349.99m, // m is for Moolah!
},
new Product
{
Id = 3,
Title = "GEFORCE RTX 3080",
Description = "The GeForce RTX™ 3080 Ti and RTX 3080 graphics cards deliver the ultra performance that gamers crave, powered by Ampere—NVIDIA’s 2nd gen RTX architecture. They are built with enhanced RT Cores and Tensor Cores, new streaming multiprocessors, and superfast G6X memory for an amazing gaming experience.",
ImageUrl = "https://sm.pcmag.com/t/pcmag_uk/news/n/nvidias-rt/nvidias-rtx-3070-surpasses-2080-ti-in-select-games_vns6.1920.jpg",
Price = 649.00m, // m is for Moolah!
},
new Product
{
Id = 4,
Title = "GEFORCE RTX 3080",
Description = "The GeForce RTX™ 3080 Ti and RTX 3080 graphics cards deliver the ultra performance that gamers crave, powered by Ampere—NVIDIA’s 2nd gen RTX architecture. They are built with enhanced RT Cores and Tensor Cores, new streaming multiprocessors, and superfast G6X memory for an amazing gaming experience.",
ImageUrl = "https://sm.pcmag.com/t/pcmag_uk/news/n/nvidias-rt/nvidias-rtx-3070-surpasses-2080-ti-in-select-games_vns6.1920.jpg",
Price = 649.00m, // m is for Moolah!
},
new Product
{
Id = 5,
Title = "GEFORCE RTX 3080",
Description = "The GeForce RTX™ 3080 Ti and RTX 3080 graphics cards deliver the ultra performance that gamers crave, powered by Ampere—NVIDIA’s 2nd gen RTX architecture. They are built with enhanced RT Cores and Tensor Cores, new streaming multiprocessors, and superfast G6X memory for an amazing gaming experience.",
ImageUrl = "https://sm.pcmag.com/t/pcmag_uk/news/n/nvidias-rt/nvidias-rtx-3070-surpasses-2080-ti-in-select-games_vns6.1920.jpg",
Price = 649.00m, // m is for Moolah!
}
};*/ //Mock data

        public ProductController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await dataContext.Products.ToListAsync();
            return Ok(products);
        }
    }
}
