Features
Game Mechanics:

Two players choose hand shapes (Rock, Paper, Scissors) simultaneously.

Players remove one hand, and the remaining hands determine the winner.

Best-of-three match system.

Multiplayer & Real-Time Gameplay:

Real-time updates using SignalR.

Players can start/join game sessions.

User Management & Authentication:

JWT-based authentication.

User registration and login.

Match history and scores stored in the database.

Database Management:

MSSQL database with Entity Framework Core.

Database migrations for schema updates.

Technologies Used
Backend: ASP.NET Core, SignalR, Entity Framework Core

Database: MSSQL

Authentication: JWT (JSON Web Tokens)

Testing: xUnit, Moq

API Documentation: Swagger

Setup Instructions
Prerequisites
.NET SDK: Install the latest .NET SDK from here.

MSSQL Server: Install and configure MSSQL Server. Alternatively, use Docker to run an MSSQL container.

IDE: Use Visual Studio 2022 or Visual Studio Code with the C# extension.

Steps
Clone the repository:

bash
Copy
git clone https://github.com/your-username/RockPaperScissorsMinusOne.git
cd RockPaperScissorsMinusOne
Update the database connection string in appsettings.json:

json
Copy
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=RockPaperScissors;Trusted_Connection=True;"
  }
}
Run database migrations:

bash
Copy
dotnet ef database update
Restore NuGet packages:

bash
Copy
dotnet restore
Running the Application
Start the application:

bash
Copy
dotnet run
Access the application at:

Copy
http://localhost:5000
Use the Swagger UI to explore and test the API:

Copy
http://localhost:5000/swagger
Testing
Unit Tests
Run unit tests:

bash
Copy
dotnet test
View test results in the terminal.

Integration Tests
Integration tests can be added to test API endpoints and database interactions.

API Documentation
The API is documented using Swagger. Access the Swagger UI at:

Copy
http://localhost:5000/swagger
Endpoints
POST /api/auth/register: Register a new user.

POST /api/auth/login: Login and receive a JWT token.

POST /api/game/play: Play a round of Rock Paper Scissors Minus One.

SignalR Hub: /gamehub for real-time gameplay.

Database Schema
The database schema includes the following tables:

Users: Stores user information.

Matches: Stores match details.

MatchHistory: Stores round results for each match.

Schema Diagram
sql
Copy
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL
);

CREATE TABLE Matches (
    MatchId INT PRIMARY KEY IDENTITY,
    Player1Id INT FOREIGN KEY REFERENCES Users(Id),
    Player2Id INT FOREIGN KEY REFERENCES Users(Id),
    WinnerId INT FOREIGN KEY REFERENCES Users(Id),
    Timestamp DATETIME NOT NULL
);

CREATE TABLE MatchHistory (
    MatchHistoryId INT PRIMARY KEY IDENTITY,
    MatchId INT FOREIGN KEY REFERENCES Matches(MatchId),
    PlayerId INT FOREIGN KEY REFERENCES Users(Id),
    HandChoice NVARCHAR(10) NOT NULL, -- Rock, Paper, Scissors
    Result NVARCHAR(10) NOT NULL -- Win, Lose, Draw
);
Deployment
Docker
Build the Docker image:

bash
Copy
docker build -t rockpaperscissorsminusone .
Run the Docker container:

bash
Copy
docker run -p 5000:80 rockpaperscissorsminusone
Azure/AWS
Push the Docker image to a container registry (e.g., Azure Container Registry, AWS ECR).

Deploy the container using Kubernetes or a managed service (e.g., Azure Kubernetes Service, AWS ECS).

Contributing
Contributions are welcome! Follow these steps:

Fork the repository.

Create a new branch:

bash
Copy
git checkout -b feature/your-feature-name
Commit your changes:

bash
Copy
git commit -m "Add your feature"
Push to the branch:

bash
Copy
git push origin feature/your-feature-name
Open a pull request.

