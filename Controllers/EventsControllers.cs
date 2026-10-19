
using CampusEvents.Api.Data;
using CampusEvents.Api.Models;
using Microsoft.AspNetCore.Mvc;
using CampusEvents.Api.DTOs;

namespace CampusEvents.Api.Controllers;

[ApiController]
[Route("api/events")]
public class EventsController : ControllerBase
{

    private readonly AppDbContext _dbContext;

    public EventsController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    // GET: /api/events
    [HttpGet]
    public ActionResult<IEnumerable<CampusEvent>> GetEvents()
    {
      var events = _dbContext.CampusEvents.ToList();
        return Ok(events);
    }

    // GET: /api/events/2
    [HttpGet("{id:int}")]
    public ActionResult<CampusEvent> GetEventById(int id)
    {
        var campusEvent = _dbContext.CampusEvents.FirstOrDefault(e => e.Id == id);

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
public ActionResult<CampusEvent> CreateEvent(EventCreateDTO eventCreateDTO)
{
    var campusEvent = new CampusEvent
    {
        Name = eventCreateDTO.Name,
        Date = eventCreateDTO.StartDate, // Assuming StartDate is used for the event date
        Location = eventCreateDTO.Location,
        OrganizerId = 1, // You can set this to a valid organizer ID
        EventCategoryId = 1 // You can set this to a valid category ID
    };
{
    if (string.IsNullOrWhiteSpace(campusEvent.Name))
    {
        return BadRequest(new
        {
            message = "Event name is required."
        });
    }

    if (string.IsNullOrWhiteSpace(campusEvent.Location))
    {
        return BadRequest(new
        {
            message = "Event location is required."
        });
    }

    if (campusEvent.Date == default)
    {
        return BadRequest(new
        {
            message = "Event date is required."
        });
    }

    _dbContext.CampusEvents.Add(campusEvent);
    _dbContext.SaveChanges();

    return CreatedAtAction(nameof(GetEventById), new { id = campusEvent.Id }, campusEvent);

}
}



[HttpDelete("{id:int}")]

public IActionResult DeleteEvent(int id)
{
    var campusEvent = _dbContext.CampusEvents.FirstOrDefault(e => e.Id == id);

    if (campusEvent is null)
    {
        return NotFound(new
        {
            message = $"Event with ID {id} was not found."
        });
    }

    _dbContext.CampusEvents.Remove(campusEvent);
    _dbContext.SaveChanges();

    return NoContent();
}




[HttpPut("{id:int}")]
public ActionResult<CampusEvent> UpdateEvent(
    int id,
    EventCreateDTO eventUpdateDTO)
{
    var campusEvent = _dbContext.CampusEvents.FirstOrDefault(e => e.Id == id);

    if (campusEvent is null)
    {
        return NotFound(new
        {
            message = $"Event with ID {id} was not found."
        });
    }

    campusEvent.Name = eventUpdateDTO.Name;
    campusEvent.Date = eventUpdateDTO.StartDate; // Assuming StartDate is used for the event date
    campusEvent.Location = eventUpdateDTO.Location;

    _dbContext.SaveChanges();

    return Ok(campusEvent);



}
}