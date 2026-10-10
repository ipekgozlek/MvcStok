# 📦 MvcStok – Stock Management System

A stock management web application developed with **C# and ASP.NET MVC** to manage products, categories, customers, and sales operations.

This project was built as part of my software development learning journey to practice the MVC architecture, database operations, and dynamic web interfaces.

## 🚀 Features

- **Product Management:** List, add, update, and delete products.
- **Category Management:** Manage product categories and navigate through paginated category lists.
- **Customer Management:** List, add, update, delete, and search customers by name.
- **Sales Management:** Record sales by entering product, customer, quantity, and price information through a modal form.
- **Database Integration:** Store and manage application data using SQL Server and Entity Framework.
- **Interactive UI:** Use Bootstrap components and JavaScript confirmation dialogs for a more user-friendly experience.

## 🛠️ Technologies Used

| Technology | Purpose |
|---|---|
| C# | Application logic |
| ASP.NET MVC 5 | Web application architecture |
| .NET Framework 4.8 | Application framework |
| Entity Framework 6 | Database operations |
| SQL Server | Relational database |
| Razor | Dynamic HTML rendering |
| HTML5 & CSS3 | Page structure and styling |
| Bootstrap | Responsive layout and UI components |
| JavaScript | Client-side interactions |
| PagedList.Mvc | Pagination |

## 🏗️ Project Architecture

The project follows the **Model–View–Controller (MVC)** pattern.

- **Model:** Represents database entities and manages data access through Entity Framework.
- **View:** Displays data and provides forms and tables using Razor, HTML, and Bootstrap.
- **Controller:** Handles HTTP requests, processes application logic, and communicates with the database.

### Main Modules

| Module | Description |
|---|---|
| Products | Product listing and CRUD operations |
| Categories | Category management and pagination |
| Customers | Customer management and name-based search |
| Sales | Sales entry through a modal form |

## 🗄️ Database

The application uses **Microsoft SQL Server** with an Entity Framework Database First model.

Main database entities include:

- `TBLURUNLER` — Products
- `TBLKATEGORILER` — Categories
- `TBLMUSTERILER` — Customers
- `TBLSATISLAR` — Sales

## 📚 What I Learned

While developing this project, I practiced:

- Understanding the MVC architecture and request flow.
- Creating controllers and Razor views.
- Performing CRUD operations with Entity Framework.
- Writing LINQ queries for filtering and retrieving data.
- Using model binding to transfer form data to controller actions.
- Implementing pagination with PagedList.Mvc.
- Creating dynamic dropdown lists and modal forms.
- Using Bootstrap components and JavaScript confirmation dialogs.
- Managing relationships between products and categories.

## 🎯 Project Goal

The goal of this project was to strengthen my C# and ASP.NET MVC fundamentals through hands-on development and to build a foundation for more advanced web applications.

---

**Developed with C# and ASP.NET MVC as part of my software development journey.** 💻
