
namespace CampusEvents.Api.Models;

public class CampusEvent
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Location { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public int OrganizerId { get; set; }
    public int EventCategoryId { get; set; }
}
