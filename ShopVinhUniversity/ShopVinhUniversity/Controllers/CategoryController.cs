using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShopVinhUniversity.Data;
using ShopVinhUniversity.Entities;
using ShopVinhUniversity.Services;

namespace ShopVinhUniversity.Controllers
{
  public class CategoryController : Controller
  {
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
      _categoryService = categoryService;
    }

    // GET: Category
    public IActionResult Index()
    {
      return View(_categoryService.GetAll());
    }

    // GET: Category/Details/5
    public IActionResult Details(string id)
    {
      Category category = _categoryService.GetById(id);
      if (category == null)
      {
        return NotFound();
      }

      return View(category);
    }

    // GET: Category/Create
    public IActionResult Create()
    {
      return View();
    }

    // POST: Category/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("Title")] Category category)
    {
      if (ModelState.IsValid)
      {
        _categoryService.Create(category);

        return RedirectToAction(nameof(Index));
      }

      return View(category);
    }

    // GET: Category/Edit/5
    public IActionResult Edit(string id)
    {
      if (id == null)
      {
        return NotFound();
      }

      Category category = _categoryService.GetById(id);
      if (category == null)
      {
        return NotFound();
      }

      return View(category);
    }

    // POST: Category/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(string id, [Bind("ID,Title")] Category category)
    {
      if (id != category.ID)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        _categoryService.Update(category);

        return RedirectToAction(nameof(Index));
      }

      return View(category);
    }

    // GET: Category/Delete/5
    public IActionResult Delete(string id)
    {
      if (id == null)
      {
        return NotFound();
      }

      Category category = _categoryService.GetById(id);
      if (category == null)
      {
        return NotFound();
      }

      return View(category);
    }

    // POST: Category/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(string id)
    {
      _categoryService.Delete(id);
      return RedirectToAction(nameof(Index));
    }
  }
}
