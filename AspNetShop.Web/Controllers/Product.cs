using AspNetShop.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace AspNetShop.Web.Controllers;

public class Product: Controller
{
    private readonly IProductService _productService;

    public Product(IProductService productService)
    {
        _productService = productService ?? throw new ArgumentNullException(nameof(productService));
    }

    public async Task<IActionResult> ProductIndex()
    {
        var products = await _productService.FindAllProducts();
        return View(products);
    }
    
}