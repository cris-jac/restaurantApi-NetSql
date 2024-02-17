namespace RestaurantAPI.Models.DTO;

public class MenuItemCreateDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string SpecialTag { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    // public IFormFile File { get; set; }
}