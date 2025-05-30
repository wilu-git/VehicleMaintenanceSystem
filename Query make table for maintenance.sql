CREATE TABLE MaintenanceTypes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL UNIQUE,
    EstimatedDurationMinutes INT NOT NULL -- e.g., 60 for 1 hour
);
CREATE TABLE ScheduledMaintenance (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserId INT NOT NULL,
    VehicleId INT NOT NULL,
    MaintenanceTypeId INT NOT NULL,
    Description NVARCHAR(1000),
    ScheduledStart DATETIME NOT NULL,
    ScheduledEnd DATETIME NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MaintenanceTypeId) REFERENCES MaintenanceTypes(Id)
    -- Add UserId/VehicleId FKs as needed
);
