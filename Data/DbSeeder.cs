using CampusEvents.Api.Data;
using CampusEvents.Api.Models;
using CampusEvents.Api.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CampusEvents.Api.Data;
public static class DbSeeder
{
    public static void SeedDatabase(AppDbContext dbContext)
    {
        if (!dbContext.CampusEvents.Any())
        {
            var events = new List<CampusEvent>
            {
                new CampusEvent
                {
                    Name = "Tech Conference 2024",
                    Date = new DateTime(2024, 5, 15),
                    Location = "Main Auditorium",
                    Description = "A conference showcasing the latest in technology.",
                    OrganizerId = 1,
                    EventCategoryId = 1
                },
                new CampusEvent
                {
                    Name = "Art Exhibition",
                    Date = new DateTime(2024, 6, 10),
                    Location = "Art Gallery",
                    Description = "An exhibition of student artwork.",
                    OrganizerId = 2,
                    EventCategoryId = 2
                }
            };

            dbContext.CampusEvents.AddRange(events);
            dbContext.SaveChanges();
        }
    }
}