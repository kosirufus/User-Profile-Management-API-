# User Profile Management API

**A learning project:**  
A simple **C# / ASP.NET Web API** that manages users and their profiles, built to practice **OOP, DTOs, extension methods, and API contracts**.

---

## Project Overview

This API demonstrates how to manage users in a real-world scenario. It allows you to:

### Create Users
- Name  
- Email  
- Date of birth  
- **Profile picture** (`byte[]` for now)

### Handle Updates
- Change name or email  
- Activate or deactivate a user account

### Provide Useful Info
- Get a **user summary** (display name, email, registration date, status)  
- List all **active users**  
- Check if email is valid

### Extensible & Maintainable
- Designed so features can **easily be added** in the future  
  (e.g., search, filtering, profile management, authentication)

> Even though it’s a learning project, it uses **realistic OOP principles and API design patterns**, making it suitable for demonstrating professional-level understanding.

---

## Technologies Used
- **C#**  
- **ASP.NET Core Web API**  
- **In-memory data storage** (can be replaced with a database later)  
- **DTOs** for request and response models  
- **Extension methods** for reusable helper functions  
- **Controllers & Services** for clean separation of concerns  

---

## Key Concepts Practiced
- **Classes & Objects** – User class with properties and instance methods  
- **Instance & Extension Methods** – e.g., `GetUserSummary()`, `IsEmailValid()`  
- **DTOs** – Structured request and response objects  
- **API Contracts** – Clear request/response formats for endpoints  
- **OOP Principles** – Encapsulation, separation of concerns, maintainability  

---

## API Endpoints

### Users
| Endpoint | HTTP Method | Description |
|----------|------------|-------------|
| `/users` | POST | Create a new user |
| `/users` | GET | List all users |
| `/users/{id}` | GET | Get single user info |
| `/users/{id}` | PATCH | Update user info (name, email, activate/deactivate) |

### User Summary
| Endpoint | HTTP Method | Description |
|----------|------------|-------------|
| `/users/{id}/summary` | GET | Get user summary |
| `/users/active` | GET | Get all active users |

---

## How to Run

### Steps
1. **Clone the repository**  
2. **Open the project** in Visual Studio or VS Code  
3. **Run the API**  
```bash
dotnet run
4. Test endpoints using Postman, Swagger, or curl

**Future Improvements**
Planned Enhancements

* Add authentication & authorization

* Persist data in a database instead of in-memory storage

* Add profile picture upload & retrieval support

* Implement search, filtering, and pagination

* Include unit tests & API documentation

Even though this project is for learning, it’s structured to grow into a professional microservice.
