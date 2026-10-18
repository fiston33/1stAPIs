
using CampusEvents.Api.Models;

namespace CampusEvents.Api.Data;

public static class EventSeedData
{
    public static readonly List<Organizer> Organizers = new()
    {
        new Organizer
        {
            Id = 1,
            Name = "Student Union",
            Email = "union@campus.example"
        },
        new Organizer
        {
            Id = 2,
            Name = "Technology Club",
            Email = "techclub@campus.example"
        },
        new Organizer
        {
            Id = 3,
            Name = "Community Outreach",
            Email = "outreach@campus.example"
        }
    };

    public static readonly List<EventCategory> Categories = new()
    {
        new EventCategory
        {
            Id = 1,
            Name = "Festival",
            Description = "Campus celebrations and social activities."
        },
        new EventCategory
        {
            Id = 2,
            Name = "Technology",
            Description = "Technology talks, workshops, and innovation."
        },
        new EventCategory
        {
            Id = 3,
            Name = "Community",
            Description = "Volunteering and community activities."
        }
    };

    public static readonly List<CampusEvent> Events = new()
    {
        new CampusEvent
        {
            Id = 1,
            Name = "Spring Festival",
            Date = new DateTime(2026, 11, 10),
            Location = "Main Quad",
            Description = "Campus celebration with music and activities.",
            OrganizerId = 1,
            EventCategoryId = 1
        },
        new CampusEvent
        {
            Id = 2,
            Name = "AI in Education Workshop",
            Date = new DateTime(2026, 11, 15),
            Location = "Lecture Hall A",
            Description = "Explore artificial intelligence in education.",
            OrganizerId = 2,
            EventCategoryId = 2
        },
        new CampusEvent
        {
            Id = 3,
            Name = "Community Charity Run",
            Date = new DateTime(2026, 11, 20),
            Location = "Campus Track",
            Description = "A campus run supporting community initiatives.",
            OrganizerId = 3,
            EventCategoryId = 3
        }
    };
}
