# Zipline Applicant Management System (ZAMS)

## Description

_Duration: a few days_

This project was one that I completed back in September before I enrolled in a Javascript bootcamp. it represents the culmination of my self study in C# and .NET. 
I decided to put this project in my portfolio to show my competance with C# and my abililty to learn on my own. I myself coded no javascript in this project.

The project is a simple CRUD app that I developed because every spring I have trouble keeping track of all the people that apply to work at the Zip Line i manage.
The goal is to enter in every applicant along with their availability and interview notes. I then call them every few weeks in the spring time to check in and see if they
are still interested in working in the summer time. The app has a way to record conversations with people, as I talk to a LOT of people and their plans often change
between February and June. So it's a simple way to manage applicants and all the conversations I have with them over the course of a few months.

## Screen Shots

[All Applicants View](https://i.ibb.co/sKV8FLf/allapplicants.png)

[Applicant Details View](https://i.ibb.co/SJRs49V/applicant-details.png)

### Prerequisites

- [Dot Net 5](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Entity Framework](https://docs.microsoft.com/en-us/ef/core/get-started/overview/install)
- [MS Sql Server](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15)

You don't need EF or MSSQL but if you want to use the database functionality then you will have to install it and run the commands written below.
Right off the bat the program runs with in-memory data already written for inspection.

## Installation

My project is built in Dotnet version 5.0 and uses the razor pages framework. I also utilize Entity Framework so if you want to see database functionality you will need to have that installed on your local machine.
The database connection settings are set up to use an instance of MSSql localdb.

1. Install Dotnet 5.0, Entity Framework, and Sql Server
2. Clone the project
3. Change to the /zams/zams directory
4. Run `dotnet restore` in your terminal to install dependencies
5. Run `dotnet run` to view the site on localhost port 5000

If you want to access the data from a SQL 
1. Install Entity Framework and SQL Server
2. change to the directory zams/zams
3. Open the project in VS Code and go to the Startup.cs file. Uncomment out the lines below the comment "enable for sql server"
4. comment out the code blow "enable for in-memory testing"
5. Run `dotnet ef migrations add initialcreate -s ../zams/zams.csproj` in your terminal. the -s indicates that the target project is in another folder.
6. Run `dotnet ef database update -s ..\odetofood\odetofood.csproj` to create the database.
7. If you are having trouble you might need to add <GenerateRuntimeConfigurationFiles>True</GenerateRuntimeConfigurationFiles> to the csproj file
8. Running the `dotnet run` command will open up a new browser tab for you to view the site!

## Usage

As mentioned in the paragraph above, this site is built to keep track of all the people I interview and make plans with in the spring time before the summer
zip line season starts. I usually get over 100 people applying, I do about 50-60 interviews, and of all those people I am lucky if I walk away with 20
guides for the summer. it's very dificult to keep track of all those conversation!

To use the site properly:
1. When someone applies and has an interview set up, I will add them to the system by clicking the "Add New" button in the top right corner of the table
2. Fill out the applicant details form with their information
3. After the initial interview, I edit the applicant again and check whether they will be joining us for the summer. If they are joining us, they will be on the "Pending table"
4. If they declined the job or won't be a good fit, they end up in the "declined" table
5. I then fill out a conversation form with the date and notes from the interview. If it's the initial interview, there is a checkbox to make note of that.
6. As time goes on in the spring time, i will add more conversations as the training date draws near.
7. When it gets to be near the training week, I will then have a roster of able and willing guides that will make the final cut to train as a zip line guide!

## Built With

This project was originally built in dotnet core 3.1, but has since been updated for dotnet 5. The CSS framework I used is bootstrap, but I used a theme called "darkly "from [Bootswatch](https://bootswatch.com/darkly/)

## Acknowledgement
All the skills needed to build this project were learned from Pluralsight. 
That site proved to be a great foundation for learning to program before I enrolled in Emerging Digital Academy to learn full stack javascript.

## Support
If you have questions or issues, please email me at Mitchellscott@me.com
