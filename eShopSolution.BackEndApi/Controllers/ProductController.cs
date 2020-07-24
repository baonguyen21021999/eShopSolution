using eShopSolution.Application.Catalog.Products;
using eShopSolution.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eShopSolution.BackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _PublicProductService;
        private readonly IManageProductService _ManageProductService;
        public ProductController(IPublicProductService PublicProductService, IManageProductService ManageProductService)
        {
            _PublicProductService = PublicProductService;
            _ManageProductService = ManageProductService;
        }
        //http://localhost.port/product
        [HttpGet("{languageId}")]
        public async Task<IActionResult> Get(string languageId)
        {
            var products = await _PublicProductService.GetAll(languageId);

            return Ok(products);
        }
        //http://localhost.port/product/public-paging
        [HttpGet("public-paging/{languageId}")]
        public async Task<IActionResult> Get([FromQuery] GetPublicProductPagingRequest request)
        {
            var products = await _PublicProductService.GetAllByCategoryId(request);
            return Ok(products);
        }
        //http://localhost.port/product/1
        [HttpGet("{id}/{languageId}")]
        public async Task<IActionResult> GetById(int id, string languageId)
        {
            var product = await _ManageProductService.GetById(id, languageId);
            if (product == null)
                return BadRequest("cannot find product");
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request)
        {
            var ProductId = await _ManageProductService.Create(request);
            if (ProductId == 0)
                return BadRequest();

            var product = await _ManageProductService.GetById(ProductId, request.LanguageId);
            return CreatedAtAction(nameof(GetById), new {id = ProductId }, product);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            var affecttedResult = await _ManageProductService.Update(request);
            if (affecttedResult == 0)
                return BadRequest();

           
            return Ok();

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var affecttedResult = await _ManageProductService.Delete(id);
            if (affecttedResult == 0)
                return BadRequest();


            return Ok();
        }
        [HttpPut("price/{Id}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice( int id, decimal newPrice)
        {
            var isSuccessfull = await _ManageProductService.UpdatePrice(id, newPrice);
            if (isSuccessfull)
                return Ok() ;


            return BadRequest();

        }
    }
}
