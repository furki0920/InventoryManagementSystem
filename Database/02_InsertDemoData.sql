USE InventoryManagementSystem;
GO

INSERT INTO Brands (Name, IsActive)
VALUES
('Dell', 1),
('HP', 1),
('Lenovo', 1),
('Samsung', 1),
('Asus', 1);
GO

INSERT INTO Facilities (Name, IsActive)
VALUES
('Genel Merkez', 1),
('Kocabaş 2', 1),
('Demo Tesisi', 1);
GO

INSERT INTO MaterialTypes (Name, IsActive)
VALUES
('Notebook', 1),
('Masaüstü', 1),
('Ekran', 1),
('Yazıcı', 1),
('Switch', 1);
GO

INSERT INTO MovementTypes (Name, IsActive)
VALUES
('Envantere Eklendi', 1),
('Zimmet Verildi', 1),
('Zimmet Alındı', 1),
('Tesis Değiştirildi', 1),
('Durumu Değiştirildi', 1);
GO

INSERT INTO Statuses (Name, IsActive)
VALUES
('Zimmetli', 1),
('Hurda', 1),
('Depo', 1),
('Garantide', 1);
GO

INSERT INTO Employees (FullName, Email, IsActive)
VALUES
('Ahmet Demir', 'ahmet.demir@example.com', 1),
('Mehmet Kaya', 'mehmet.kaya@example.com', 1),
('Ayşe Yılmaz', 'ayse.yilmaz@example.com', 1),
('Zeynep Şahin', 'zeynep.sahin@example.com', 1),
('Burak Çelik', 'burak.celik@example.com', 1),
('Elif Aydın', 'elif.aydin@example.com', 1),
('Can Arslan', 'can.arslan@example.com', 1),
('Deniz Koç', 'deniz.koc@example.com', 1);
GO

INSERT INTO Devices
(
    MaterialTypeId,
    BrandId,
    EmployeeId,
    FacilityId,
    StatusId,
    DeviceModel,
    Cpu,
    Ram,
    DiskSize,
    SerialNumber,
    ActivationDate,
    AssignmentDate,
    EstimatedLife,
    Notes,
    IsActive
)
VALUES
(1, 1, 1, 1, 1, 'Latitude 5440', 'Intel Core i5', '16 GB', '512 GB SSD', 'DEMO-LAPTOP-001', '2026-01-10', '2026-01-15', '5 Yıl', 'Demo cihaz', 1),
(1, 2, 2, 1, 1, 'ProBook 450', 'Intel Core i5', '16 GB', '512 GB SSD', 'DEMO-LAPTOP-002', '2026-01-12', '2026-01-20', '5 Yıl', 'Demo cihaz', 1),
(1, 3, NULL, 2, 3, 'ThinkPad E14', 'Intel Core i5', '8 GB', '256 GB SSD', 'DEMO-LAPTOP-003', '2026-02-01', NULL, '5 Yıl', 'Depoda bekliyor', 1),
(2, 1, 3, 1, 1, 'OptiPlex 7010', 'Intel Core i5', '16 GB', '512 GB SSD', 'DEMO-DESKTOP-001', '2026-02-05', '2026-02-10', '6 Yıl', 'Demo cihaz', 1),
(3, 4, NULL, 2, 3, 'S24F350', NULL, 'N/A', 'N/A', 'DEMO-MONITOR-001', '2026-02-12', NULL, '7 Yıl', 'Depoda', 1),
(3, 5, 4, 1, 1, '24MK400H', NULL, 'N/A', 'N/A', 'DEMO-MONITOR-002', '2026-02-15', '2026-02-18', '7 Yıl', 'Demo cihaz', 1),
(4, 2, NULL, 3, 3, 'LaserJet Pro', NULL, 'N/A', 'N/A', 'DEMO-PRINTER-001', '2026-03-01', NULL, '6 Yıl', 'Demo yazıcı', 1),
(5, 3, NULL, 2, 4, 'ThinkSystem Switch', NULL, 'N/A', 'N/A', 'DEMO-SWITCH-001', '2026-03-05', NULL, '5 Yıl', 'Garanti kapsamında', 1),
(1, 1, 5, 3, 1, 'Latitude 3520', 'Intel Core i5', '8 GB', '256 GB SSD', 'DEMO-LAPTOP-004', '2026-03-10', '2026-03-15', '5 Yıl', 'Demo cihaz', 1),
(2, 4, NULL, 1, 2, 'VivoPC', 'Intel Core i3', '8 GB', '256 GB SSD', 'DEMO-DESKTOP-002', '2026-03-12', NULL, '5 Yıl', 'Demo hurda kayıt', 1);
GO

INSERT INTO DeviceMovements
(
    DeviceId,
    MovementType,
    FromEmployeeId,
    ToEmployeeId,
    FromFacilityId,
    ToFacilityId,
    FromStatusId,
    ToStatusId,
    Description,
    MovementDate
)
VALUES
(3, 'Envantere Eklendi', NULL, NULL, NULL, 2, NULL, 3, 'Cihaz demo envanterine eklendi.', '2026-03-01'),
(1, 'Zimmet Verildi', NULL, 1, 1, 1, 3, 1, 'Cihaz personele zimmetlendi.', '2026-03-02'),
(2, 'Zimmet Verildi', NULL, 2, 1, 1, 3, 1, 'Cihaz personele zimmetlendi.', '2026-03-03'),
(5, 'Tesis Değiştirildi', NULL, NULL, 1, 2, 3, 3, 'Cihaz demo tesisine taşındı.', '2026-03-05'),
(10, 'Durumu Değiştirildi', NULL, NULL, 1, 1, 3, 2, 'Cihaz hurda durumuna alındı.', '2026-03-10');
GO