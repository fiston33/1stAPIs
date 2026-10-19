using System.ComponentModel.DataAnnotations;
namespace CampusEvents.Api.DTOs;


public class EventResponseDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Location { get; set; }
}

public class EventCreateDTO
{
    [Required(ErrorMessage = "Event name is required."),MinLength(3, ErrorMessage = "Event name must be at least 3 characters long.")]
    [MaxLength(100, ErrorMessage = "Event name cannot exceed 100 characters.")]
    public string Name { get; set; }

    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Event location is required.")]
    [MaxLength(200, ErrorMessage = "Event location cannot exceed 200 characters.")]
    public string Location { get; set; }
}

public class EventUpdateDTO
{
    [Required(ErrorMessage = "Event name is required.")]
    [MinLength(3, ErrorMessage = "Event name must be at least 3 characters long.")]
    [MaxLength(100, ErrorMessage = "Event name cannot exceed 100 characters.")]
    public string Name { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Event location is required.")]
    [MaxLength(200, ErrorMessage = "Event location cannot exceed 200 characters.")]
    public string Location { get; set; }
}