
```markdown
# Code First Relation with Entity Framework Core

This project demonstrates how to implement a **one-to-many relationship** between `UserEntity` and `PostEntity` using **Entity Framework Core (EF Core)** with the **Code First Approach**.

## 📌 Technologies Used
- C#
- .NET 8
- Entity Framework Core
- PostgreSQL
- ASP.NET Core

## 📌 Database Schema
- `Users`
  - `Id` (Primary Key, Auto Increment)
  - `UserName` (Required)
  - `Email` (Required, Unique)
  - `Posts` (One-to-Many Relationship)

- `Posts`
  - `Id` (Primary Key, Auto Increment)
  - `Title` (Required)
  - `Content`
  - `UserId` (Foreign Key to `Users`)

## 📌 Project Structure
```
CodeFirstRelation/
│── Context/
│   ├── PatikaSecondDbContext.cs  # Database context
│── Entities/
│   ├── UserEntity.cs             # User entity
│   ├── PostEntity.cs             # Post entity
│── appsettings.json              # Database connection settings
│── Program.cs                    # Main entry point
│── README.md                     # Project documentation
```

## 📌 Setup Instructions
### **1. Clone the repository**
```bash
git clone https://github.com/pelinbasaslan/CodeFirstBasic.git
cd CodeFirstBasic
```

### **2. Install dependencies**
```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
```

### **3. Configure the database connection**
Edit the `appsettings.json` file and update the PostgreSQL connection string:

```json
{
  "ConnectionStrings": {
    "defaultConnection": "Host=localhost;Port=5432;Database=PatikaCodeFirstDb2;Username=postgres;Password=yourpassword"
  }
}
```

### **4. Apply migrations**
Run the following commands to create the database and tables:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### **5. Run the application**
Start the application with:

```bash
dotnet run
```

## 📌 License
This project is open-source and available under the MIT License.
```

---

🚀 **Now your project is well-documented and ready to use!**