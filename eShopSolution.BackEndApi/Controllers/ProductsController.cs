using eShopSolution.Application.Catalog.Products;
using eShopSolution.ViewModels.Catalog.ProductImages;
using eShopSolution.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eShopSolution.BackEndApi.Controllers
{
    //api/product
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _PublicProductService;
        private readonly IManageProductService _ManageProductService;
        public ProductsController(IPublicProductService PublicProductService, IManageProductService ManageProductService)
        {
            _PublicProductService = PublicProductService;
            _ManageProductService = ManageProductService;
        }
        //http://localhost:port/product
        //[HttpGet("{languageId}")]
        /*public async Task<IActionResult> GetAll(string languageId)
        {
            var products = await _PublicProductService.GetAll(languageId);

            return Ok(products);
        }*/
        //http://localhost:port/products?pageIndex=1,pageSize=10&categoryId=
        [HttpGet("{languageId}")]
        public async Task<IActionResult> GetAllPaging(string languageId, [FromQuery] GetPublicProductPagingRequest request)
        {
            var products = await _PublicProductService.GetAllByCategoryId(languageId, request);
            return Ok(products);
        }
        //http://localhost:port/product/1
        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var product = await _ManageProductService.GetById(productId, languageId);
            if (product == null)
                return BadRequest("cannot find product");
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }    
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
        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affecttedResult = await _ManageProductService.Delete(productId);
            if (affecttedResult == 0)
                return BadRequest();


            return Ok();
        }
        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice( int productId, decimal newPrice)
        {
            var isSuccessfull = await _ManageProductService.UpdatePrice(productId, newPrice);
            if (isSuccessfull)
                return Ok() ;


            return BadRequest();

        }
        //image
        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage(int productId, [FromForm]ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _ManageProductService.AddImage(productId, request);
            if (imageId == 0)
                return BadRequest();

            var image = await _ManageProductService.GetImageById(imageId);
            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }
        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _ManageProductService.UpdateImage(imageId, request);
            if (result == 0)
                return BadRequest();

            
            return Ok();
        }
        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _ManageProductService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();


            return Ok();
        }
        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _ManageProductService.GetImageById(imageId);
            if (image == null)
                return BadRequest("cannot find product");
            return Ok(image);
        }
    }
}
