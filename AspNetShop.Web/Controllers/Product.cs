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
    
    public async Task<IActionResult> ProductUpdate(long id)
    {
        var productModel = await _productService.FindProductById(id);
        if (productModel != null) return View(productModel);
        return NotFound();
    }
    
    [HttpPost]
    public async Task<IActionResult> ProductUpdate(ProductModel productModel)
    {
        if (ModelState.IsValid)
        {
            var response = await _productService.UpdateProduct(productModel);
            if (response != null) return RedirectToAction(nameof(ProductIndex));
        }
        
        return View(productModel);
    }
    
}