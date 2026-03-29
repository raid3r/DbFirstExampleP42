INSERT INTO CarMakers (Title, Country, FoundedYear) VALUES
('Toyota', 'Japan', 1937),
('Honda', 'Japan', 1948),
('Ford', 'USA', 1903),
('Chevrolet', 'USA', 1911),
('Tesla', 'USA', 2003),
('BMW', 'Germany', 1916),
('Audi', 'Germany', 1909),
('Mercedes-Benz', 'Germany', 1926),
('Volkswagen', 'Germany', 1937),
('Subaru', 'Japan', 1953),
('Nissan', 'Japan', 1933),
('Hyundai', 'South Korea', 1967),
('Kia', 'South Korea', 1944),
('Mazda', 'Japan', 1920),
('Lexus', 'Japan', 1989),
('Acura', 'Japan', 1986),
('Infiniti', 'Japan', 1989),
('Cadillac', 'USA', 1902),
('Lincoln', 'USA', 1917),
('Volvo', 'Sweden', 1927);


INSERT INTO Cars (MakeId, Model, Year, Color, InStock, Price) VALUES
(1, 'Camry', 2020, 'Red', 1, 24000.00), -- 1
(2, 'Civic', 2019, 'Blue', 1, 22000.00),
(3, 'Mustang', 2021, 'Black', 0, 35000.00),
(4, 'Impala', 2018, 'White', 1, 18000.00),
(5, 'Model 3', 2022, 'Silver', 1, 40000.00),
(6, '3 Series', 2020, 'Gray', 0, 35000.00),
(7, 'A4', 2019, 'Blue', 1, 37000.00),
(8, 'C-Class', 2021, 'Black', 1, 42000.00),
(9, 'Passat', 2018, 'White', 1, 20000.00),
(10, 'Outback', 2022, 'Green', 1, 28000.00),
(11, 'Altima', 2020, 'Red', 1, 23000.00),
(12, 'Elantra', 2019, 'Blue', 1, 21000.00),
(13, 'Optima', 2021, 'Black', 0, 25000.00),
(14, '6', 2018, 'White', 1, 19000.00),
(15, 'ES', 2022, 'Silver', 1, 38000.00),
(16, 'TLX', 2020, 'Gray', 0, 36000.00),
(17, 'Q50', 2019, 'Blue', 1, 33000.00),
(18, 'CTS', 2021, 'Black', 1, 45000.00),
(19, 'MKZ', 2018, 'White', 1, 22000.00),
(20, 'S60', 2022, 'Green', 1, 31000.00);


INSERT INTO Reviews (CarId, Comment, Rating) VALUES
(1, 'Great car, very reliable!', 5),
(2, 'Good value for the price.', 4),
(3, 'Not as powerful as I expected.', 3),
(4, 'Comfortable and spacious interior.', 4),
(5, 'Amazing performance and technology.', 5),
(6, 'Luxury feel but a bit pricey.', 4),
(7, 'Stylish design and smooth ride.', 5),
(8, 'High-quality materials and features.', 5),
(9, 'Decent car but not very exciting.', 3),
(10, 'Perfect for outdoor adventures.', 4),
(11, 'Reliable and fuel-efficient.', 5),
(12, 'Affordable and practical.', 4),
(13, 'Good performance but lacks features.', 3),
(14, 'Fun to drive and great handling.', 5),
(15, 'Luxurious and comfortable.', 5),
(16, 'Solid performance but a bit expensive.', 4),
(17, 'Sleek design and powerful engine.', 5),
(18, 'High-end features but pricey.', 4),
(19, 'Comfortable but not very exciting.', 3),
(20, 'Safe and reliable with good performance.', 4),
(1, 'Had some issues with the infotainment system.', 3),
(2, 'Great fuel economy and smooth ride.', 5),
(3, 'Not the best choice for long trips.', 2),
(4, 'Spacious trunk and comfortable seats.', 4),
(5, 'Impressive acceleration and handling.', 5),
(6, 'Luxurious interior but a bit noisy.', 4),
(7, 'Sleek design and responsive steering.', 5),
(8, 'High-quality materials but a bit stiff ride.', 4),
(9, 'Decent car but lacks excitement.', 3),
(10, 'Perfect for family outings and road trips.', 5),
(11, 'Reliable and comfortable for daily commuting.', 5),
(12, 'Affordable and practical for city driving.', 4),
(13, 'Good performance but lacks advanced features.', 3),
(14, 'Fun to drive with great handling.', 5),
(15, 'Luxurious and comfortable for long drives.', 5),
(16, 'Solid performance but a bit expensive.', 4),
(17, 'Sleek design and powerful engine.', 5),
(18, 'High-end features but pricey.', 4),
(19, 'Comfortable but not very exciting.', 3),
(20, 'Safe and reliable with good performance.', 4);


INSERT INTO AdditionalOptions (Title) VALUES
('Sunroof'),
('Leather Seats'),
('Navigation System'),
('Bluetooth Connectivity'),
('Backup Camera'),
('Heated Seats'),
('Premium Sound System'),
('Remote Start'),
('Blind Spot Monitoring'),
('Apple CarPlay/Android Auto');

INSERT INTO CarAdditionalOptions (CarId, OptionId) VALUES
(1, 1), -- Camry with Sunroof
(1, 2), -- Camry with Leather Seats
(2, 3), -- Civic with Navigation System
(2, 4), -- Civic with Bluetooth Connectivity
(3, 5), -- Mustang with Backup Camera
(3, 6), -- Mustang with Heated Seats
(4, 7), -- Impala with Premium Sound System
(4, 8), -- Impala with Remote Start
(5, 9), -- Model 3 with Blind Spot Monitoring
(5, 10), -- Model 3 with Apple CarPlay/Android Auto
(6, 1), -- 3 Series with Sunroof
(6, 2), -- 3 Series with Leather Seats
(7, 3), -- A4 with Navigation System
(7, 4), -- A4 with Bluetooth Connectivity
(8, 5), -- C-Class with Backup Camera
(8, 6), -- C-Class with Heated Seats
(9, 7), -- Passat with Premium Sound System
(9, 8), -- Passat with Remote Start
(10, 9), -- Outback with Blind Spot Monitoring
(10, 10), -- Outback with Apple CarPlay/Android Auto
(11, 1), -- Altima with Sunroof
(11, 2), -- Altima with Leather Seats
(12, 3), -- Elantra with Navigation System
(12, 4), -- Elantra with Bluetooth Connectivity
(13, 5), -- Optima with Backup Camera
(13, 6), -- Optima with Heated Seats
(14, 7), -- 6 with Premium Sound System
(14, 8), -- 6 with Remote Start
(15, 9), -- ES with Blind Spot Monitoring
(15, 10), -- ES with Apple CarPlay/Android Auto
(16, 1), -- TLX with Sunroof
(16, 2), -- TLX with Leather Seats
(17, 3), -- Q50 with Navigation System
(17, 4), -- Q50 with Bluetooth Connectivity
(18, 5), -- CTS with Backup Camera
(18, 6), -- CTS with Heated Seats
(19, 7), -- MKZ with Premium Sound System
(19, 8), -- MKZ with Remote Start
(20, 9), -- S60 with Blind Spot Monitoring
(20, 10);-- S60 with Apple CarPlay/Android Auto