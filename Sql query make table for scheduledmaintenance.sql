CREATE TABLE ScheduledMaintenance (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    VehicleId INT NOT NULL,
    MaintenanceTypeId INT NOT NULL,
    Description NVARCHAR(1000),
    ScheduledStart DATETIME NOT NULL,
    ScheduledEnd DATETIME NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    CONSTRAINT UserID FOREIGN KEY (UserId) REFERENCES Users(Id),
    CONSTRAINT VehicleID FOREIGN KEY (VehicleId) REFERENCES Vehicles(VehicleID)
);