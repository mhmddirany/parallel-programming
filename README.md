# Investigation Files Manager (projprog)

A Windows desktop application for managing criminal investigation files: the people involved, their face photos and fingerprints, and related vehicles. Built with **C# WinForms (.NET 6)** and **MySQL** via **Entity Framework Core**, using **asynchronous and concurrent database access** to keep the interface responsive.

> Course project – Parallel Programming

## Features

- **Investigations** – add, edit, delete and list investigation files (serial, entry date, transaction date, crime, seized evidence, summary, notes).
- **People** – record every person linked to a file (name, parents, nationality, birthplace, residence, gender, status, phone, occupation…).
- **Biometrics** – store front/left/right face photos and right/left thumbprints for each person as images in the database.
- **Vehicles** – record vehicles linked to a file (plate, chassis, engine, brand, model, owner details).
- **Classification / search** – select one or more crime keywords to list all matching investigations.
- Arabic user interface.

## Parallel / asynchronous programming

| Technique | Where | Why |
|---|---|---|
| `async` / `await` for every database call | `Repositories/Controllers/*` | The UI thread is never blocked while MySQL answers. |
| `Task.WhenAll` | `FormPerson.Initialize` | Villages, nations and attributes load **concurrently**, so total time ≈ the slowest query instead of the sum. |
| One `DbContext` per operation | Every controller method | `DbContext` is not thread-safe; separate instances make concurrent queries safe. |
| Disabling controls during requests (`UpdatecanClick`) | All forms | Prevents the user from starting overlapping operations on the same data. |
| `await` resumes on the UI thread | All forms | Controls can be updated safely after each query without `Invoke`. |

## Architecture

```
Forms (UI)  →  Controllers (data access)  →  DatabaseContext (EF Core)  →  MySQL
```

```
projprog/
├── Program.cs                 # Entry point – opens FormMain
├── Forms/                     # WinForms screens
│   ├── FormMain               # Start screen
│   ├── FormInvest             # Investigation files (main screen)
│   ├── FormPerson             # People in a file
│   ├── FormFace / FormFP      # Face photos / fingerprints
│   ├── FormVehicle            # Vehicles in a file
│   └── FormWord               # Search by crime keyword
├── Repositories/
│   ├── DatabaseContext.cs     # EF Core context and connection
│   ├── Models/                # One class per table
│   └── Controllers/           # Async CRUD methods per table
└── Utilities/                 # Image <-> blob conversion, error dialogs
```

### Database tables

| Table | Key | Contents |
|---|---|---|
| `invest` | `Serial` | Investigation files |
| `invperson` | `Serial` + `Serpers` | People in each file |
| `imageFace` | `Serial` + `Serpers` | Face photos (blobs) |
| `imageFP` | `Serial` + `Serpers` | Fingerprints (blobs) |
| `vehicle` | `Vid` | Vehicles, linked by `Serial` |
| `nation`, `village`, `attr`, `worldkey` | `Code` | Lookup lists (`Code`, `Label`) |

## Getting started

### Requirements

- Windows
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) (or Visual Studio 2022)
- MySQL Server 8

### Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/mhmddirany/parallel-programming.git
   ```
2. Create a MySQL database named `projectdb` with the tables listed above.
3. Set your connection string in `projprog/Repositories/DatabaseContext.cs`:
   ```csharp
   "Server=localhost;Port=3306;Database=projectdb;User=<user>;Password=<password>;"
   ```
4. Run the app:
   ```bash
   cd parallel-programming/projprog
   dotnet run
   ```
   or open `projprog.csproj` in Visual Studio and press **F5**.

## Usage

1. Click **Investigate** on the start screen.
2. Add or select an investigation file.
3. Use **اشخاص** (people), **سيارات** (vehicles) or **تصنيف** (classify) to manage data linked to that file.
4. From the people screen, open face photos or fingerprints for the selected person.

## Tech stack

- C# / .NET 6 / Windows Forms
- Entity Framework Core 6
- Pomelo.EntityFrameworkCore.MySql
- MySQL

## Author

Mohamad Dirany – [@mhmddirany](https://github.com/mhmddirany)
