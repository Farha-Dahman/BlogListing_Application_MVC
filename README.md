# Blog Listing Application

This is a **Blog Listing Application** built with **ASP.NET Core MVC**. The application allows users to manage blog posts by providing features such as creating, editing, deleting, searching, and filtering blogs by categories.

# Features

- **Create a New Blog Post:** Add a new blog with details such as title, content, author, published date, and category.

- **View All Blogs:** List all blogs with a responsive layout.

- **Edit Blogs:** Update existing blog details.

- **Delete Blogs:** Remove blogs from the list.

- **Search Blogs:** Search blogs by title or author.

- **Category Filtering:** Filter blogs by category.

- **Responsive Design:** Fully responsive layout using Bootstrap.

# Technologies Used

- **Framework:** .NET Core 8.0

- **Architecture:** MVC (Model-View-Controller)

- **Styling:** Bootstrap 5

- **Database:** Entity Framework Core with SQL Server

- **Language:** C#

- **Tools:** Visual Studio, SQL Server Management Studio.

# Installation

### Clone the Repository
```
https://github.com/Farha-Dahman/BlogListing_Application_MVC.git
```

# Setup the Database

1. Open the appsettings.json file and configure the connection string:
```
"ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=BlogListingDB;Trusted_Connection=True;"
}
```

2. Run the following commands to apply migrations and seed the database:
```
Add-Migration Initial

Update-Database
```

# Run the Application

1. Open the project in Visual Studio.

2. Press Ctrl+F5 to run the application.

# Usage

**1. Create Blogs:**

  - Click on the "Create New Blog" button.

  - Fill in the details and submit.

**2. View Blogs:**

  - Navigate to the homepage to view all blogs.

**3. Search Blogs:**

  - Use the search box to find blogs by title or author.

**4. Filter Blogs:**

  - Use the filter dropdown to view blogs by category.

**5. Edit or Delete:**

  - Use the "Edit" or "Delete" buttons to modify or remove blogs.

