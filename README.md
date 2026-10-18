# 1stAPIs — Campus Events API

My first ASP.NET Core Web API project, built with C# and .NET 10. This project is part of my journey toward becoming a software engineer, learning REST APIs, and building applications that can connect to web and mobile clients.

## About the Project

Campus Events API is a beginner-friendly RESTful API for retrieving campus event information. It currently uses in-memory sample data and provides endpoints for listing events and retrieving an individual event by ID.

## Technologies

- C#
- .NET 10
- ASP.NET Core Web API
- Controller-based routing
- OpenAPI
- Scalar API Reference

## Features

- Retrieve all campus events.
- Retrieve an event by its ID.
- Return HTTP 404 when an event is not found.
- Explore and test endpoints through Scalar API Reference.
- Organize code into models, controllers, and data files.

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/events` | Retrieve all events |
| GET | `/api/events/{id}` | Retrieve an event by ID |

## Sample Event Data

The sample data includes:

- Spring Festival
- AI in Education Workshop
- Community Charity Run

## Run Locally

### Prerequisites

Install the [.NET SDK](https://dotnet.microsoft.com/download).

### Steps

1. Clone the repository:

   ```bash
   git clone https://github.com/fiston33/1stAPIs.git
   ```

2. Enter the project directory:

   ```bash
   cd 1stAPIs/CampusEvents.Api
   ```

   If the `.csproj` file is directly in the cloned repository root, skip into that root instead.

3. Restore dependencies:

   ```bash
   dotnet restore
   ```

4. Build the project:

   ```bash
   dotnet build
   ```

5. Run the API:

   ```bash
   dotnet run
   ```

6. Open the Scalar API Reference using the HTTPS URL and port shown in the terminal, followed by `/scalar/v1`.

## Current Limitations

- Event data is stored in memory and resets when the application restarts.
- A database has not yet been integrated.

## Roadmap

- [ ] Add create, update, and delete event endpoints.
- [ ] Add organizers and event categories endpoints.
- [ ] Integrate a database using Entity Framework Core.
- [ ] Add input validation and error handling.
- [ ] Add authentication and authorization.
- [ ] Write automated tests.
- [ ] Prepare the API for a future mobile application.

## Author

**Fiston BYIRINGIRO**

GitHub: [@fiston33](https://github.com/fiston33)

---

*Learning by building, one API at a time.*