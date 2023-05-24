using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Review
  {
    public string Critic { get; set; }
    public int Rating { get; set; }
    public string Entry { get; set; }
    public int ReviewId { get; set;  }
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    // public List<Restaurant> Restaurants { get; set; }
  }
}