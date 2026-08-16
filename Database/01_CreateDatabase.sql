USE InventoryManagementSystem;
GO

CREATE TABLE Brands
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedDate DATETIME2(7) NOT NULL DEFAULT GETDATE(),
    UpdatedDate DATETIME2(7) NULL
);
GO

CREATE TABLE Facilities
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(150) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedDate DATETIME2(7) NOT NULL DEFAULT GETDATE(),
    UpdatedDate DATETIME2(7) NULL
);
GO

CREATE TABLE MaterialTypes
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedDate DATETIME2(7) NOT NULL DEFAULT GETDATE(),
    UpdatedDate DATETIME2(7) NULL
);
GO

CREATE TABLE MovementTypes
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedDate DATETIME2(7) NOT NULL DEFAULT GETDATE(),
    UpdatedDate DATETIME2(7) NULL
);
GO

CREATE TABLE Statuses
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedDate DATETIME2(7) NOT NULL DEFAULT GETDATE(),
    UpdatedDate DATETIME2(7) NULL
);
GO

CREATE TABLE Employees
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(150) NOT NULL,
    Email NVARCHAR(150) NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedDate DATETIME2(7) NOT NULL DEFAULT GETDATE(),
    UpdatedDate DATETIME2(7) NULL
);
GO

CREATE TABLE Devices
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MaterialTypeId INT NOT NULL,
    BrandId INT NOT NULL,
    EmployeeId INT NULL,
    FacilityId INT NOT NULL,
    StatusId INT NOT NULL,
    DeviceModel NVARCHAR(150) NULL,
    Cpu NVARCHAR(150) NULL,
    Ram NVARCHAR(50) NULL,
    DiskSize NVARCHAR(50) NULL,
    SerialNumber NVARCHAR(150) NULL,
    ActivationDate DATETIME2(7) NULL,
    AssignmentDate DATETIME2(7) NULL,
    EstimatedLife NVARCHAR(50) NULL,
    Notes NVARCHAR(MAX) NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedDate DATETIME2(7) NOT NULL DEFAULT GETDATE(),
    UpdatedDate DATETIME2(7) NULL,

    CONSTRAINT FK_Devices_MaterialTypes
        FOREIGN KEY (MaterialTypeId) REFERENCES MaterialTypes(Id),

    CONSTRAINT FK_Devices_Brands
        FOREIGN KEY (BrandId) REFERENCES Brands(Id),

    CONSTRAINT FK_Devices_Employees
        FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),

    CONSTRAINT FK_Devices_Facilities
        FOREIGN KEY (FacilityId) REFERENCES Facilities(Id),

    CONSTRAINT FK_Devices_Statuses
        FOREIGN KEY (StatusId) REFERENCES Statuses(Id)
);
GO

CREATE TABLE DeviceMovements
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    DeviceId INT NOT NULL,
    MovementType NVARCHAR(100) NOT NULL,
    FromEmployeeId INT NULL,
    ToEmployeeId INT NULL,
    FromFacilityId INT NULL,
    ToFacilityId INT NULL,
    FromStatusId INT NULL,
    ToStatusId INT NULL,
    Description NVARCHAR(500) NULL,
    MovementDate DATETIME2(7) NOT NULL,
    CreatedDate DATETIME2(7) NOT NULL DEFAULT GETDATE(),

    CONSTRAINT FK_DeviceMovements_Devices
        FOREIGN KEY (DeviceId) REFERENCES Devices(Id),

    CONSTRAINT FK_DeviceMovements_FromEmployee
        FOREIGN KEY (FromEmployeeId) REFERENCES Employees(Id),

    CONSTRAINT FK_DeviceMovements_ToEmployee
        FOREIGN KEY (ToEmployeeId) REFERENCES Employees(Id),

    CONSTRAINT FK_DeviceMovements_FromFacility
        FOREIGN KEY (FromFacilityId) REFERENCES Facilities(Id),

    CONSTRAINT FK_DeviceMovements_ToFacility
        FOREIGN KEY (ToFacilityId) REFERENCES Facilities(Id),

    CONSTRAINT FK_DeviceMovements_FromStatus
        FOREIGN KEY (FromStatusId) REFERENCES Statuses(Id),

    CONSTRAINT FK_DeviceMovements_ToStatus
        FOREIGN KEY (ToStatusId) REFERENCES Statuses(Id)
);
GO