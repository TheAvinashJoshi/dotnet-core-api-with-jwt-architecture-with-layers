# ASP.NET Core Web API Template  

This is a template for ASP.NET Core Web API projects, designed with a modular architecture to keep things clean, scalable, and easy to maintain.  

It follows a layered structure with Auth, Core, Data, and Services layers, along with the main API layer.  

One can download and use in their projects

---

## Project Structure  

### 1. Auth Layer  
- Responsible for Authentication & Authorization.  
- Generates and manages JWT tokens for secure API access.  
- Can be extended to support role-based and policy-based authorization.  

---

### 2. Core Layer  
- Acts as the foundation of the project.  
- Contains:  
  - Enums – For standardized values.  
  - Constants – For common reusable values.  
  - DTOs (Data Transfer Objects) – For request/response models.  
  - Entities/Models – For domain/business objects.  
- Ensures a clean separation between data and business logic.  

---

### 3. Data Layer  
- Handles all database-related operations.  
- Implements generic repositories for data access.  
- Can work with Entity Framework, Dapper, or any ORM.  
- Think of it as the bridge to the actual database.  

---

### 4. Services Layer  
- Contains the business logic.  
- Services are injected into controllers.  
- Ensures that controllers remain thin and only handle HTTP requests.  
- Makes unit testing easier by separating concerns.  

---

### 5. API Layer  
- The main ASP.NET Core Web API project.  
- Contains controllers that:  
  - Accept requests.  
  - Call services.  
  - Return structured responses.  
- Serves as the entry point for clients.  

---

## Key Benefits  
- Clean Architecture – Separation of concerns with layered structure.  
- Scalable – Easy to extend with new services, repositories, and features.  
- Testable – Services and repositories can be unit tested independently.  
- Flexible – Works with EF Core, Dapper, or any other data provider.  

---

## Contact  
For any queries or suggestions, feel free to reach out:  

Email: [ajoshi0100@gmail.com](mailto:ajoshi0100@gmail.com)  
