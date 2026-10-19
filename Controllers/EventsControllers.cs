
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


    [HttpPost]
public ActionResult<CampusEvent> CreateEvent(
    [FromBody] CampusEvent newEvent)
{
    // Validate required fields
    if (string.IsNullOrWhiteSpace(newEvent.Name))
    {
        return BadRequest(new
        {
            message = "Event name is required."
        });
    }

    if (string.IsNullOrWhiteSpace(newEvent.Location))
    {
        return BadRequest(new
        {
            message = "Event location is required."
        });
    }

    if (newEvent.Date == default)
    {
        return BadRequest(new
        {
            message = "Event date is required."
        });
    }

    // Generate the next ID
    newEvent.Id = EventSeedData.Events.Count == 0
        ? 1
        : EventSeedData.Events.Max(e => e.Id) + 1;

    // Save the event in memory
    EventSeedData.Events.Add(newEvent);

    // Return HTTP 201 Created
    return CreatedAtAction(
        nameof(GetEventById),
        new { id = newEvent.Id },
        newEvent);
}


[HttpDelete("{id:int}")]
public IActionResult DeleteEvent(int id)
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

    EventSeedData.Events.Remove(campusEvent);

    return NoContent();
}




[HttpPut("{id:int}")]
public ActionResult<CampusEvent> UpdateEvent(
    int id,
    [FromBody] CampusEvent updatedEvent)
{
    var existingEvent = EventSeedData.Events
        .FirstOrDefault(e => e.Id == id);

    if (existingEvent is null)
    {
        return NotFound(new
        {
            message = $"Event with ID {id} was not found."
        });
    }

    if (string.IsNullOrWhiteSpace(updatedEvent.Name))
    {
        return BadRequest(new
        {
            message = "Event name is required."
        });
    }

    if (string.IsNullOrWhiteSpace(updatedEvent.Location))
    {
        return BadRequest(new
        {
            message = "Event location is required."
        });
    }

    if (updatedEvent.Date == default)
    {
        return BadRequest(new
        {
            message = "Event date is required."
        });
    }

    // Update the existing event
    existingEvent.Name = updatedEvent.Name;
    existingEvent.Date = updatedEvent.Date;
    existingEvent.Location = updatedEvent.Location;
    existingEvent.Description = updatedEvent.Description;
    existingEvent.OrganizerId = updatedEvent.OrganizerId;
    existingEvent.EventCategoryId = updatedEvent.EventCategoryId;

    return Ok(existingEvent);
}


}
