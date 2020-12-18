using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopVinhUniversity.Data;
using ShopVinhUniversity.Entities;
using ShopVinhUniversity.Services;

namespace ShopVinhUniversity.Controllers
{
  public class ProductController : Controller
  {
    private readonly ApplicationDbContext _context;
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;

    public ProductController(ApplicationDbContext context, IProductService productService, ICategoryService categoryService)
    {
      _context = context;
      _productService = productService;
      _categoryService = categoryService;
    }

    // GET: Product
    public IActionResult Index()
    {
      return View(_productService.GetAll());
    }

    // GET: Product/Details/5
    public IActionResult Details(string id)
    {
      if (id == null)
      {
        return NotFound();
      }

      Product product = _productService.GetById(id);
      if (product == null)
      {
        return NotFound();
      }

      return View(product);
    }

    // GET: Product/Create
    public IActionResult Create()
    {
      ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Title");
      return View();
    }

    // POST: Product/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("Name,Price,ThumbnailSrc,CategoryID")] Product product)
    {
      if (ModelState.IsValid)
      {
        _productService.Create(product);

        return RedirectToAction(nameof(Index));
      }

      ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Title", product.CategoryID);
      return View(product);
    }

    // GET: Product/Edit/5
    public IActionResult Edit(string id)
    {
      if (id == null)
      {
        return NotFound();
      }

      Product product = _productService.GetById(id);
      if (product == null)
      {
        return NotFound();
      }

      ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Title", product.CategoryID);
      return View(product);
    }

    // POST: Product/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(string id, [Bind("ID,Name,Price,ThumbnailSrc,CategoryID")] Product product)
    {
      if (id != product.ID)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        _productService.Update(product);

        return RedirectToAction(nameof(Index));
      }

      ViewData["CategoryID"] = new SelectList(_context.Categories, "ID", "Title", product.CategoryID);
      return View(product);
    }

    // GET: Product/Delete/5
    public IActionResult Delete(string id)
    {
      if (id == null)
      {
        return NotFound();
      }

      Product product = _productService.GetById(id);
      if (product == null)
      {
        return NotFound();
      }

      return View(product);
    }

    // POST: Product/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(string id)
    {
      _productService.Delete(id);
      return RedirectToAction(nameof(Index));
    }
  }
}
