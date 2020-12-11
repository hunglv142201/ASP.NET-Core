using Microsoft.AspNetCore.Mvc;
using ShopVinhUniversity.Services;
using System.ComponentModel.DataAnnotations;

namespace ShopVinhUniversity.Controllers
{
  public class ProductController : Controller
  {
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
      _productService = productService;
    }

    [HttpGet]
    public IActionResult Detail(string id)
    {
      return View(_productService.GetById(id));
    }
  }
}
