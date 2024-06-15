# stock_market_data

# CRUD Application Using Code First Approach in ASP.NET Core 6

This project demonstrates a basic CRUD (Create, Read, Update, Delete) application using the Code First approach with Entity Framework Core in ASP.NET Core 6. 

# Features : 

1. Create 

2. Read and list 

3. Update 

5. Delete

6. Data Visualization

# Prerequisites :

1. .NET 6 SDK

2. Visual Studio 2022 or any other preferred IDE

3. SQL Server


1. Clone the Repository

git clone https://github.com/yourusername/CrudAppCodeFirst.git
cd CrudAppCodeFirst

2. Set Up the Database
Update the connection string in appsettings.json to match your SQL Server configuration:

"ConnectionStrings": {
  "DefaultConnection": "Server=your_server_name;Database=CrudAppDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}

3. Apply Migrations
Run the following commands in the Package Manager Console or via CLI to create the database and apply the migrations:

dotnet ef migrations add InitialCreate
dotnet ef database update


4. Run the Application
Use the following command to run the application:

dotnet run
