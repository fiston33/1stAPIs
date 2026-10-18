
using CampusEvents.Api.Data;
using CampusEvents.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace CampusEvents.Api.Controllers;

[ApiController]
[Route("api/events")]
public class EventsController : ControllerBase
{
    // GET: /api/events
    [HttpGet]
    public ActionResult<IEnumerable<CampusEvent>> GetEvents()
    {
        return Ok(EventSeedData.Events);
    }

    // GET: /api/events/2
    [HttpGet("{id:int}")]
    public ActionResult<CampusEvent> GetEventById(int id)
    {
        var campusEvent = EventSeedData.Events
            .FirstOrDefault(e => e.Id == id);

        if (campusEvent is null)
        {
            return NotFound(new
            {
                message = $"Event with ID {id} was not found."
            });
        }

        return Ok(campusEvent);
    }
}
