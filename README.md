# 1stAPIs — Campus Events API

My first ASP.NET Core Web API project, built with C# and .NET 10 to learn HTTP, RESTful API design, controllers, and API documentation with Scalar.

## About the Project

Campus Events API is a learning project that exposes HTTP endpoints for retrieving campus event information. It demonstrates how an ASP.NET Core Web API receives requests and returns structured JSON responses.

## Technologies

- C#
- .NET 10
- ASP.NET Core Web API
- Controller-based routing
- Scalar API Reference
- OpenAPI

## Current Features

- Retrieve all campus events.
- Retrieve an individual event by ID.
- Return `404 Not Found` when an event does not exist.
- Explore and test API endpoints using Scalar.
- Work with sample campus event data.

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/events` | Retrieve all events |
| GET | `/api/events/{id}` | Retrieve an event by ID |

## Sample Events

The current version includes three sample events:

1. Spring Festival
2. AI in Education Workshop
3. Community Charity Run

**Note:** The current sample data is stored in memory. Database persistence using Entity Framework Core is planned for a future version.

## Run Locally

### Prerequisites

- .NET 10 SDK
- Visual Studio Code or another compatible editor
- Git

### 1. Clone the repository

```bash
git clone https://github.com/YOUR-USERNAME/1stAPIs.git
cd 1stAPIs
```

Replace `YOUR-USERNAME` with your GitHub username.

### 2. Restore dependencies

```bash
dotnet restore
```

### 3. Build the project

```bash
dotnet build
```

### 4. Run the API

```bash
dotnet run
```

Check the terminal for the local HTTP and HTTPS addresses.

### 5. Open Scalar

Navigate to the Scalar URL configured in the application, commonly:

`https://localhost:YOUR-PORT/scalar/v1`

Replace `YOUR-PORT` with the HTTPS port printed by the application.

## Learning Roadmap

- [x] Create an ASP.NET Core Web API project.
- [x] Configure Scalar API documentation.
- [x] Create campus event models and sample data.
- [x] Implement GET endpoints.
- [ ] Add POST, PUT, PATCH, and DELETE endpoints.
- [ ] Integrate Entity Framework Core.
- [ ] Persist events in a database.
- [ ] Add validation and standardized error responses.
- [ ] Implement authentication and authorization.
- [ ] Prepare the API for mobile application integration.

## Purpose

This project documents my journey learning professional API development with .NET. It will evolve as I explore HTTP, REST principles, data access, testing, and secure API design.

## License

A license has not yet been selected. Add an appropriate license before allowing others to reuse the project.
