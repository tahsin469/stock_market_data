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
3. 
Update the connection string in appsettings.json to match your SQL Server configuration:

"ConnectionStrings": {

  "DefaultConnection": "Server=your_server_name;Database=CrudAppDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}

3. Apply Migrations
4. 
Run the following commands in the Package Manager Console or via CLI to create the database and apply the migrations:

dotnet ef migrations add InitialCreate

dotnet ef database update


4. Run the Application
   
Use the following command to run the application:

dotnet run

![Screenshot (11620)](https://github.com/tahsin469/stock_market_data/assets/76706081/efa2b06e-4c12-4256-bcfc-f8eb337327aa)
![Screenshot (11621)](https://github.com/tahsin469/stock_market_data/assets/76706081/bd4c0f30-23e9-4e4f-9786-125715693c94)
![Screenshot (11622)](https://github.com/tahsin469/stock_market_data/assets/76706081/6bca1057-fa40-4113-90ca-f0f4397556e6)
![Screenshot (11623)](https://github.com/tahsin469/stock_market_data/assets/76706081/7e62dfed-d865-46af-a5d4-8517ff90ec14)
![Screenshot (11624)](https://github.com/tahsin469/stock_market_data/assets/76706081/c929f9d7-fa4f-48ef-8d6c-94b39a1dad4e)
![Screenshot (11625)](https://github.com/tahsin469/stock_market_data/assets/76706081/8e2e5a05-83fa-478c-aa6b-4d72bc6117e6)








