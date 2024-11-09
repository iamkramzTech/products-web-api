# Products Web API

This is a Web API project for managing products. Built with ASP.NET Core 8.0.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)

## Overview

The Products Web API allows you to manage product information including creating, reading, updating, and deleting (CRUD) operations.

## Features

- RESTful API design
- CRUD operations for products
- Authentication and authorization
- Validation and error handling
- Swagger/OpenAPI documentation
- Unit and integration tests

## Prerequisites

- [.NET SDK 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) IDE or later
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any other database supported by Entity Framework Core

## Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/iamkramzTech/products-web-api.git
    ```
2. Navigate to the project directory:
    ```bash
    cd products-web-api
    ```
3. Restore the dependencies:
    ```bash
    dotnet restore
    ```

## Configuration

1. Update the `appsettings.json` file with your database connection string and other settings:
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "YourConnectionStringHere"
      },
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft": "Warning",
          "Microsoft.Hosting.Lifetime": "Information"
        }
      }
    }
    ```

## Usage

1. Run the application:
    ```bash
    dotnet run
    ```
2. The API will be available at `https://localhost:5001`.

## API Endpoints

| Method | Endpoint               | Description              |
|--------|------------------------|--------------------------|
| GET    | `/api/products`        | Get all products         |
| GET    | `/api/products/{id}`   | Get product by ID        |
| POST   | `/api/products`        | Create a new product     |
| PUT    | `/api/products/{id}`   | Update an existing product|
| DELETE | `/api/products/{id}`   | Delete a product         |

### Sample Request

**GET /api/products**

```http
GET /api/products HTTP/1.1
Host: localhost:5001
Accept: application/json
