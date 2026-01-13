# School Management System

## Overview
The School Management System is an application designed to manage a list of schools and students. It utilizes Entity Framework for data access and provides a set of functionalities to perform CRUD (Create, Read, Update, Delete) operations on student records.

## Project Structure
The project is organized as follows:

```
SchoolManagement
├── SchoolManagement.sln
├── .gitignore
├── README.md
├── src
│   └── SchoolManagement
│       ├── SchoolManagement.csproj
│       ├── Program.cs
│       ├── appsettings.json
│       ├── Data
│       │   ├── SchoolDbContext.cs
│       │   └── Migrations
│       ├── Models
│       │   ├── Student.cs
│       │   └── School.cs
│       ├── Services
│       │   ├── StudentManager.cs
│       │   └── SchoolManager.cs
│       ├── Repositories
│       │   └── IRepository.cs
│       └── Properties
│           └── launchSettings.json
└── tests
    └── SchoolManagement.Tests
        ├── SchoolManagement.Tests.csproj
        └── StudentManagerTests.cs
```

## Features
- **Student Management**: Add, update, delete, and display student records with validation.
- **School Management**: Manage school records (to be implemented in `SchoolManager`).
- **Pagination**: Display students in a paginated format.
- **Data Validation**: Ensure data integrity through validation annotations.

## Getting Started
1. **Clone the Repository**: 
   ```
   git clone <repository-url>
   cd SchoolManagement
   ```

2. **Install Dependencies**: 
   Ensure you have the necessary packages installed. You can use the following command:
   ```
   dotnet restore
   ```

3. **Database Setup**: 
   Configure your database connection string in `appsettings.json`. Then, run the migrations to set up the database:
   ```
   dotnet ef database update
   ```

4. **Run the Application**: 
   Start the application using:
   ```
   dotnet run
   ```

## Testing
Unit tests for the application can be found in the `tests/SchoolManagement.Tests` directory. To run the tests, navigate to the test project directory and execute:
```
dotnet test
```

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.