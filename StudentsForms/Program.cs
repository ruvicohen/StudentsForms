using Microsoft.Extensions.Configuration;
using StudentsForms.DAL;
using StudentsForms.Forms;
/*CREATE TABLE Courses
(
	ID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(100),
	Cycle INT,
	StartDate DATETIME,
	EndDate DATETIME,
	TotalHours INT,
	Price INT,
	UNIQUE (Name, Cycle)
)
CREATE TABLE Lecturers
(
	ID INT PRIMARY KEY IDENTITY,
	TZ INT,
	Name VARCHAR(100),
	Phone INT,
	PriceForHour INT
	UNIQUE (TZ, Name)
)
CREATE TABLE Subjects
(
	ID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(100),
	LecturerID INT FOREIGN KEY REFERENCES Lecturers(ID),
	CoursID INT FOREIGN KEY REFERENCES Courses(ID),
	TotalHour INT  

)
CREATE TABLE Students
(
	ID INT PRIMARY KEY IDENTITY,
	TZ INT,
	Name VARCHAR(100),
	Phone INT,
	Debt INT
	UNIQUE (TZ, Name)
)
CREATE TABLE Payments
(
	ID INT PRIMARY KEY IDENTITY,
	Payment INT,
	StudentID INT FOREIGN KEY REFERENCES Students(ID)
)
CREATE TABLE Intersted
(
	ID INT PRIMARY KEY IDENTITY,
	Name VARCHAR(100),
	Phone INT,
	CoursID INT FOREIGN KEY REFERENCES Courses(ID)
)
CREATE TABLE StudentsINCours
(
	ID INT PRIMARY KEY IDENTITY,
	StudentID INT FOREIGN KEY REFERENCES Students(ID),
	CoursID INT FOREIGN KEY REFERENCES Courses(ID),
	UNIQUE (StudentID, CoursID)
)

CREATE TABLE Days
(
	ID INT PRIMARY KEY IDENTITY,
	Day VARCHAR(100),
	StartHour INT,
	EndHour INT,
	CoursID INT FOREIGN KEY REFERENCES Courses(ID)	
	UNIQUE (Day, CoursID)
)*/
namespace StudentsForms
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string conn = config["Connection"];
            if (string.IsNullOrEmpty(conn))
            {
                throw new ArgumentNullException("Connection string is missing");
            }
            DBContext dbContext = new DBContext(conn);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomePageForm(dbContext));
        }
    }
}