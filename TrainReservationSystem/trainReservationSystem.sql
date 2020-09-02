CREATE TABLE trainAdmin
(
adminId VARCHAR(15) NOT NULL PRIMARY KEY,
adminName VARCHAR(50) NOT NULL,
adminPassword VARCHAR(16) NOT NULL,
adminContact DEC(11) NOT NULL,
adminEmail VARCHAR(50) NOT NULL UNIQUE,
adminAddress VARCHAR(50)
);

CREATE TABLE Trains
(
trainNo VARCHAR(10) NOT NULL PRIMARY KEY,
trainName VARCHAR(50) NOT NULL,
trainSource VARCHAR(20) NOT NULL,
destination VARCHAR(20) NOT NULL,
arrivalTime TIME,
departureTime TIME,
trainCoaches DEC(2),
acSeats DEC(5),
economySeats DEC(5)
);

use TrainReservationSystem
alter table trains
add fare int 

CREATE TABLE Ticket
(
ticketNo INT NOT NULL PRIMARY KEY,
trainNo VARCHAR (10) NOT NULL,
userID VARCHAR (15) NOT NULL,
ticketPrice INT NOT NULL,
seatType VARCHAR(10) NOT NULL,
FOREIGN KEY (trainNo) REFERENCES Trains (trainNo),
);

CREATE TABLE Passengers
(
userID VARCHAR(15) NOT NULL PRIMARY KEY,
passengerName varchar(50) Not Null,
userGender VARCHAR(10),
userAge DEC(3),
userEmail VARCHAR(50) NOT NULL UNIQUE,
userCnic DEC(13) NOT NULL UNIQUE,
userMobNo DEC(11)NOT NULL,
userCity VARCHAR(30) NOT NULL,
seatNo DEC(2),
userDestination VARCHAR(30),
userSource VARCHAR(30),
seatType VARCHAR(10),
ticketNo INT,
trainNo varchar(10) ,
Foreign key (trainNo) references Trains(trainNO),
FOREIGN  KEY (ticketNo) REFERENCES Ticket(ticketNo)
);

CREATE TABLE Stations
(
stationNo INT NOT NULL PRIMARY KEY,
stationName VARCHAR(30) NOT NULL,
trainNo VARCHAR(10),
arrivalTime TIME ,
departureTime TIME
FOREIGN  KEY (trainNo) REFERENCES Trains(TrainNo),
);

drop table Stations

create table passenger_signup
(
pId int IDENTITY(1,1) Primary key ,	
pFirstName varchar(100) Not NULL,
pLastName varchar(100) NULL,
pCnic dec(13) NOT null,
pEmail varchar(40) NOT NULL,
age int NULL,
pGender varchar (10) NULL,
pContact dec(11) NOT NULL,
pCity varchar (30) NULL,
pPassword varchar(16) NOT NULL
)



alter table trainUsers 
add PassengerName varchar(50) NULL;

INSERT INTO trainAdmin("adminId","adminName","adminEmail","adminContact","adminAddress","adminPassword")
VALUES ('admin','Rehman Ali','merehmanali@gmail.com','03495502045','Narowal','admin123');

use TrainReservationSystem
alter table trainUsers
add coachNo int