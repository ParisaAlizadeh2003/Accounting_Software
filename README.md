# Accounting Software - Windows Forms Application

This is a **Windows Forms-based Accounting Software** developed using a **5-layer architecture**. The application communicates with a **SQL Server** database using the **Database First** approach, and follows **Repository** and **Unit of Work** design patterns for efficient data access and transaction management.

## Features

- **User-friendly Windows Forms Interface**: The application provides an intuitive interface for users to manage accounts, record transactions, and generate financial reports.
- **5-Layer Architecture**: The project is structured to separate concerns across different layers:
  1. **Presentation Layer (UI)**: Handles user interactions through Windows Forms.
  2. **Application Layer**: Contains business logic for accounting tasks.
  3. **Domain Layer**: Defines the core entities like `Account`, `Transaction`, etc.
  4. **Data Access Layer**: Manages data operations with **Entity Framework (Database First)**.
  5. **Infrastructure Layer**: Provides support services like logging and configuration.

## Technologies

- **Windows Forms**: To build the desktop application interface.
- **SQL Server**: For storing all accounting-related data.
- **Entity Framework (Database First)**: Models and database context are generated from the existing database schema.
- **Repository Pattern**: Abstracts database operations to promote flexibility.
- **Unit of Work Pattern**: Manages transactions across multiple repositories to ensure consistency.

## Design Patterns

1. **Repository Pattern**: Provides a clean abstraction layer over data access, ensuring that business logic is not tightly coupled to the database implementation.
2. **Unit of Work Pattern**: Ensures that multiple changes across different repositories are committed as a single transaction, providing consistency and integrity.

## Benefits

- **Separation of Concerns**: Each layer is dedicated to a specific responsibility, making the application easier to maintain and extend.
- **Modular and Scalable**: The architecture allows for easy updates or replacement of components without affecting the entire system.
- **Consistency in Data Operations**: Using Unit of Work ensures that all data changes happen within a single transaction, reducing the risk of data corruption.

## Getting Started

1. **Set Up the Database**: Use SQL Server to create the database and then generate the models using the **Entity Framework Database First** approach.
2. **Configure the Application**: Update the connection string in the application’s configuration file.
3. **Run the Application**: Open the solution in Visual Studio and run the project.
