using AspNetShop.Web.Models;
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
    
    public async Task<IActionResult> ProductCreate()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> ProductCreate(ProductModel productModel)
    {
        if (ModelState.IsValid)
        {
            var response = await _productService.CreateProduct(productModel);
            if (response != null) return RedirectToAction(nameof(ProductIndex));
        }
        
        return View(productModel);
    }
    
}