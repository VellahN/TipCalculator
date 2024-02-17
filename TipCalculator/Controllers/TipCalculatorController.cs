using System.Web.Mvc;

public class TipCalculatorController : Controller
{
  public ActionResult Index()
  {
    return View(new MealCostModel());
  }

  [HttpPost]
  [ValidateAntiForgeryToken]
  public ActionResult Index(MealCostModel model)
  {
    if (ModelState.IsValid)
    {
      model.CalculateTips();
      return View(model);
    }

    return View(model);
  }
}