CREATE DATABASE MaritimeDB;
USE MaritimeDB;

CREATE TABLE Ships (
  ShipId INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(100) NOT NULL,
  MaxSpeed DECIMAL(5,2) NOT NULL
);

CREATE TABLE Ports (
  PortId INT AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(255) NOT NULL,
  Country VARCHAR(255) NOT NULL
);

CREATE TABLE Voyages (
  VoyageId INT AUTO_INCREMENT PRIMARY KEY,
  VoyageDate DATE NOT NULL,
  DeparturePortId INT,
  ArrivalPortId INT,
  VoyageStart DATETIME,
  VoyageEnd DATETIME,
  ShipId INT,
  FOREIGN KEY (DeparturePortId) REFERENCES Ports(PortId),
  FOREIGN KEY (ArrivalPortId) REFERENCES Ports(PortId),
  FOREIGN KEY (ShipId) REFERENCES Ships(ShipId)
);

CREATE TABLE CountriesVisited (
  CountryVisitedId INT AUTO_INCREMENT PRIMARY KEY,
  CountryName VARCHAR(255) NOT NULL,
  VisitDate DATE NOT NULL
);

INSERT INTO Ships (Name, MaxSpeed) VALUES
('Ship 1', 20.5),
('Ship 2', 21.3),
('Ship 3', 26.3);

INSERT INTO Ports (Name, Country) VALUES
('Port of Rotterdam', 'Netherlands'),
('Port of Shanghai', 'China'),
('Port of Los Angeles', 'USA'),
('Port of Singapore', 'Singapore');

INSERT INTO Voyages (VoyageDate, DeparturePortId, ArrivalPortId, VoyageStart, VoyageEnd, ShipId) VALUES
('2025-04-01', 1, 2, '2025-04-01 08:00:00', '2025-04-10 16:00:00', 1),
('2025-04-15', 2, 3, '2025-04-15 09:30:00', '2025-04-25 18:45:00', 2),
('2025-05-01', 3, 4, '2025-05-01 07:15:00', '2025-05-12 20:00:00', 3);

INSERT INTO CountriesVisited (CountryName, VisitDate) VALUES
('Netherlands', '2025-04-01'),
('China', '2025-04-10'),
('USA', '2025-04-25'),
('Singapore', '2025-05-12');
