using Microsoft.AspNetCore.Mvc;
using ShopVinhUniversity.DTO.HomeDTO;
using ShopVinhUniversity.Entities;
using ShopVinhUniversity.Services;
using System.Collections.Generic;
using System.Linq;

namespace ShopVinhUniversity.Controllers
{
  public class HomeController : Controller
  {
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;

    public HomeController(IProductService productService, ICategoryService categoryService)
    {
      _productService = productService;
      _categoryService = categoryService;
    }

    [HttpGet]
    public IActionResult Index(string categoryID)
    {
      Category category = null;
      if (categoryID != null)
      {
        category = _categoryService.GetById(categoryID);
      }

      List<Category> categories = _categoryService.GetAll().ToList();
      List<Product> products = _productService.GetAll().Where(e => categoryID == null ? true : e.Category.ID == categoryID).ToList();

      return View(new IndexModel
      {
        Products = products,
        Categories = categories,
        ActiveCategory = category
      });
    }

    public IActionResult Details(string id)
    {
      return View(_productService.GetById(id));
    }
  }
}
