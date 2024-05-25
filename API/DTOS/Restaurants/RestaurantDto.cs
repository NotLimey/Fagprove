using API.DTOS.Review;

namespace API.DTOS.Restaurants;

public class RestaurantDto
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public string Slug { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    public string FoodType { get; set; } = string.Empty;
    
    public string Address { get; set; } = string.Empty;
    
    // Sat State to Innlandet as default since the assignment is about Innlandet. IN the future, this would preferably be changed to string.Empty;
    public string State { get; set; } = "Innlandet";
    
    public string City { get; set; } = string.Empty;
    
    public string ZipCode { get; set; } = string.Empty;
    
    public string PhoneNumber { get; set; } = string.Empty;
    
    public string Website { get; set; } = string.Empty;
    
    public string ImageUrl { get; set; } = string.Empty;
    
    // Add a json property for opening hours
    public OpeningHoursDto OpeningHours { get; set; } = null!;
    
    public double Latitude { get; set; }
    
    public double Longitude { get; set; }
    
    // LLM generated summary based on all information and reviews
    public string Summary { get; set; } = string.Empty;

    public IEnumerable<ReviewDto> Reviews { get; set; } = [];
}