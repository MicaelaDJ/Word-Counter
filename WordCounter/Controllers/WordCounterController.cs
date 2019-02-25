using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Counter> allCounters = Counter.GetAll();
      return View(allCounters);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string word, string sentence)
    {
      Counter myCounter = new Counter(word, sentence);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Counter.ClearAll();
      return View();
    }
  }
}
