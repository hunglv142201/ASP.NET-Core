using Microsoft.AspNetCore.Mvc;
using ShopVinhUniversity.Services;

namespace ShopVinhUniversity.Controllers
{
  public class HomeController : Controller
  {
    private readonly IProductService _productService;

    public HomeController(IProductService productService)
    {
      _productService = productService;
    }

    public IActionResult Index()
    {
      return View(_productService.GetAll());
    }
  }
}
