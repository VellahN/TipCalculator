using System.ComponentModel.DataAnnotations;

public class MealCostModel
{
  [Required(ErrorMessage = "The cost of the meal is required.")]
  [Range(1, double.MaxValue, ErrorMessage = "The cost of the meal must be a valid number greater than 0.")]
  public decimal MealCost { get; set; }

  public decimal Tip15Percent { get; set; }
  public decimal Tip20Percent { get; set; }
  public decimal Tip25Percent { get; set; }

  public void CalculateTips()
  {
    Tip15Percent = MealCost * 0.15m;
    Tip20Percent = MealCost * 0.20m;
    Tip25Percent = MealCost * 0.25m;
  }
}