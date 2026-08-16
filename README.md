# Inventory Management System

A desktop-based inventory and IT asset management application developed with **C# Windows Forms** and **Microsoft SQL Server** during my mandatory internship at **ABLFOODS**.

The project was developed to provide a more structured way of managing employees, devices, assignments, and device movements instead of relying on manual inventory tracking processes.

---

## Features

### 👤 Employee Management

* Add new employees
* Update employee information
* Search employees
* Soft-delete and restore employees
* View devices assigned to an employee

### 💻 Device Management

* Add and update devices
* Search and filter devices
* Track device status
* Assign devices to employees
* Prevent duplicate serial numbers
* Soft-delete devices

### 📦 Assignment Management

* Assign devices to employees
* View assigned devices
* Track assignment information
* Manage assignment changes

### 🔄 Device Movement Tracking

* Record device movements
* Track employee changes
* Track facility changes
* Track status changes
* View movement history
* Search movement records

### ⚙️ Supporting Modules

* Brand management
* Facility management
* Material type management
* Status management
* Movement type management

---

## Technologies

| Technology               | Usage                   |
| ------------------------ | ----------------------- |
| **C#**                   | Application development |
| **Windows Forms**        | Desktop user interface  |
| **.NET**                 | Application framework   |
| **Microsoft SQL Server** | Database management     |
| **ADO.NET**              | Database communication  |
| **Visual Studio**        | Development environment |

---

## Project Structure

```text id="vypg0r"
InventoryManagementSystem
│
├── DAL
│   └── Repository classes and data access operations
│
├── Forms
│   └── Windows Forms interfaces
│
├── Helpers
│   └── Database connection and utility classes
│
├── Models
│   └── Application data models
│
├── Database
│   ├── 01_CreateDatabase.sql
│   └── 02_InsertDemoData.sql
│
├── Properties
│
├── App.config.example
├── InventoryManagementSystem.csproj
└── InventoryManagementSystem.slnx
```

---

## Database

The application uses **Microsoft SQL Server** as its relational database.

The repository includes SQL scripts that allow the database structure and demo data to be recreated locally.

```text id="84gd52"
Database/
├── 01_CreateDatabase.sql
└── 02_InsertDemoData.sql
```

### Setup

1. Create a database named:

```text id="ovxgd3"
InventoryManagementSystem
```

2. Execute `01_CreateDatabase.sql`.
3. Execute `02_InsertDemoData.sql`.
4. Copy `App.config.example` and rename it to `App.config`.
5. Update the connection string according to your local SQL Server configuration.
6. Build and run the application.

---

## Architecture

The application follows a simple layered structure that separates the user interface, application models, and database access operations.

```text id="p1d1d1"
Forms
  ↓
DAL / Repositories
  ↓
Database
```

This structure keeps database operations separate from the user interface and makes the application easier to maintain and extend.

---

## Development Highlights

During development, the project involved practical implementation of:

* Relational database design
* SQL Server table and relationship design
* CRUD operations
* Repository pattern
* Foreign key relationships
* Data validation
* Search and filtering
* Soft-delete functionality
* Device assignment tracking
* Movement history tracking

The project was developed incrementally, starting with database design and continuing through data access and Windows Forms interface development.

---

## Privacy & Security

This repository **does not contain real company records or credentials**.

All personnel information, email addresses, device records, serial numbers, and other sample data are fictional and intended only for demonstration purposes.

The original company database, server information, authentication credentials, and other confidential information used during the internship are **not included in this repository**.

---

## Future Improvements

Potential future improvements include:

* User authentication
* Role-based authorization
* Audit logging
* Advanced reporting
* Excel/PDF export
* Improved filtering and dashboard features
* UI/UX improvements

---

## Contact

[LinkedIn](www.linkedin.com/in/furkan-akça-030354295/) · [GitHub](https://github.com/furki0920)

