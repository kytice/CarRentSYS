DROP TABLE Reservations;
DROP TABLE Vehicles;
DROP TABLE Models;
DROP TABLE Rates;

CREATE TABLE Rates (
    TypeCode CHAR(3) NOT NULL,
    Name VARCHAR2(15) NOT NULL,
    DailyRate NUMERIC(5,2) NOT NULL,
    CONSTRAINT pk_Rates PRIMARY KEY (TypeCode)
);

CREATE TABLE Models (
    ModelID NUMERIC(3) NOT NULL,
    Make VARCHAR2(15) NOT NULL,
    Model VARCHAR2(15) NOT NULL,
    CONSTRAINT pk_Models PRIMARY KEY (ModelID)
);

CREATE TABLE Vehicles (
    RegNum VARCHAR2(12) NOT NULL,
    ModelID NUMERIC(3) NOT NULL,
    TypeCode CHAR(3) NOT NULL,
    Trans CHAR(1) CHECK (Trans IN ('M', 'A')), -- Transmission (M for Manual, A for Automatic)
    Fuel CHAR(1) CHECK (Fuel IN ('P', 'D', 'H', 'E')), -- Fuel type (P for Petrol, D for Diesel, H for Hybrid, E for Electric)
    Avail CHAR(1) DEFAULT 'A',
    CONSTRAINT pk_Vehicles PRIMARY KEY (RegNum),
    CONSTRAINT fk_Vehicles_Models FOREIGN KEY (ModelID) REFERENCES Models,
    CONSTRAINT fk_Vehicles_Rates FOREIGN KEY (TypeCode) REFERENCES Rates
);


CREATE TABLE Reservations (
    ResID NUMBER(5) NOT NULL,
    FName VARCHAR2(20) NOT NULL,
    SName VARCHAR2(20) NOT NULL,
    Email VARCHAR2(100) NOT NULL,
    Phone VARCHAR2(12) NOT NULL,
    RegNum VARCHAR2(12) NOT NULL,
    ResDate DATE NOT NULL,
    PickupDate DATE NOT NULL,
    ReturnDate DATE NOT NULL,
    ActReturnDate DATE,
    Cost NUMBER(7,2) NOT NULL,
    Status CHAR(1) NOT NULL,
    License VARCHAR2(9),
    CONSTRAINT pk_Reservations PRIMARY KEY (ResID),
    CONSTRAINT fk_Reservations_Vehicles FOREIGN KEY (RegNum) REFERENCES Vehicles
);


INSERT INTO Rates (TypeCode, Name, DailyRate) VALUES ('ECO', 'Economy', 30.00);
INSERT INTO Rates (TypeCode, Name, DailyRate) VALUES ('STD', 'Standard', 40.00);
INSERT INTO Rates (TypeCode, Name, DailyRate) VALUES ('SPT', 'Sport', 65.00);
INSERT INTO Rates (TypeCode, Name, DailyRate) VALUES ('LUX', 'Luxury', 80.00);
INSERT INTO Rates (TypeCode, Name, DailyRate) VALUES ('GRN', 'Green', 50.00);
INSERT INTO Rates (TypeCode, Name, DailyRate) VALUES ('SUV', 'SUV', 45.00);
INSERT INTO Rates (TypeCode, Name, DailyRate) VALUES ('MNV', 'Minivan', 70.00);


INSERT INTO Models (ModelID, Make, Model) VALUES (1, 'Toyota', 'Camry');
INSERT INTO Models (ModelID, Make, Model) VALUES (2, 'Honda', 'NSX');
INSERT INTO Models (ModelID, Make, Model) VALUES (3, 'Ford', 'Mustang');
INSERT INTO Models (ModelID, Make, Model) VALUES (4, 'Chevrolet', 'Corvette');
INSERT INTO Models (ModelID, Make, Model) VALUES (5, 'Nissan', 'GT-R');
INSERT INTO Models (ModelID, Make, Model) VALUES (6, 'Hyundai', 'Elantra');
INSERT INTO Models (ModelID, Make, Model) VALUES (7, 'BMW', '3 Series');
INSERT INTO Models (ModelID, Make, Model) VALUES (8, 'Mercedes-Benz', 'C-Class');
INSERT INTO Models (ModelID, Make, Model) VALUES (9, 'Audi', 'A4');
INSERT INTO Models (ModelID, Make, Model) VALUES (10, 'Lexus', 'IS');
INSERT INTO Models (ModelID, Make, Model) VALUES (11, 'Chevrolet', 'Cruze');
INSERT INTO Models (ModelID, Make, Model) VALUES (12, 'Ford', 'Focus');
INSERT INTO Models (ModelID, Make, Model) VALUES (13, 'Volkswagen', 'Jetta');
INSERT INTO Models (ModelID, Make, Model) VALUES (14, 'Subaru', 'Impreza');
INSERT INTO Models (ModelID, Make, Model) VALUES (15, 'Toyota', 'Corolla');
INSERT INTO Models (ModelID, Make, Model) VALUES (16, 'Nissan', 'Sentra');
INSERT INTO Models (ModelID, Make, Model) VALUES (17, 'BMW', 'M2');
INSERT INTO Models (ModelID, Make, Model) VALUES (18, 'Hyundai', 'Veloster N');
INSERT INTO Models (ModelID, Make, Model) VALUES (19, 'Kia', 'Stinger');
INSERT INTO Models (ModelID, Make, Model) VALUES (20, 'Mazda', 'MX-5 Miata');
INSERT INTO Models (ModelID, Make, Model) VALUES (21, 'Toyota', 'Supra');
INSERT INTO Models (ModelID, Make, Model) VALUES (22, 'Chevrolet', 'Impala');
INSERT INTO Models (ModelID, Make, Model) VALUES (23, 'Ford', 'Taurus');
INSERT INTO Models (ModelID, Make, Model) VALUES (24, 'Mercedes-Benz', 'A-Class');
INSERT INTO Models (ModelID, Make, Model) VALUES (25, 'BMW', '1 Series');
INSERT INTO Models (ModelID, Make, Model) VALUES (26, 'Audi', 'A3');
INSERT INTO Models (ModelID, Make, Model) VALUES (27, 'Lexus', 'UX');
INSERT INTO Models (ModelID, Make, Model) VALUES (28, 'Cadillac', 'CT4');
INSERT INTO Models (ModelID, Make, Model) VALUES (29, 'Ford', 'Fiesta');
INSERT INTO Models (ModelID, Make, Model) VALUES (30, 'Volkswagen', 'Golf');
INSERT INTO Models (ModelID, Make, Model) VALUES (31, 'Subaru', 'Legacy');
INSERT INTO Models (ModelID, Make, Model) VALUES (32, 'Mazda', 'Mazda3');
INSERT INTO Models (ModelID, Make, Model) VALUES (33, 'Kia', 'Rio');
INSERT INTO Models (ModelID, Make, Model) VALUES (34, 'Toyota', 'Prius');
INSERT INTO Models (ModelID, Make, Model) VALUES (35, 'Honda', 'Insight');
INSERT INTO Models (ModelID, Make, Model) VALUES (36, 'Lexus', 'CT');
INSERT INTO Models (ModelID, Make, Model) VALUES (37, 'Honda', 'Clarity');
INSERT INTO Models (ModelID, Make, Model) VALUES (38, 'Honda', 'CR-V');
INSERT INTO Models (ModelID, Make, Model) VALUES (39, 'Ford', 'Escape Hybrid');
INSERT INTO Models (ModelID, Make, Model) VALUES (40, 'Chevrolet', 'Bolt EV');
INSERT INTO Models (ModelID, Make, Model) VALUES (41, 'Nissan', 'Leaf');
INSERT INTO Models (ModelID, Make, Model) VALUES (42, 'Hyundai', 'Tucson');
INSERT INTO Models (ModelID, Make, Model) VALUES (43, 'Kia', 'Sportage');
INSERT INTO Models (ModelID, Make, Model) VALUES (44, 'Subaru', 'Forester');
INSERT INTO Models (ModelID, Make, Model) VALUES (45, 'Toyota', 'Sienna');
INSERT INTO Models (ModelID, Make, Model) VALUES (46, 'Honda', 'Odyssey');
INSERT INTO Models (ModelID, Make, Model) VALUES (47, 'Chrysler', 'Pacifica');
INSERT INTO Models (ModelID, Make, Model) VALUES (48, 'Kia', 'Sedona');
INSERT INTO Models (ModelID, Make, Model) VALUES (49, 'Toyota', 'RAV4');
INSERT INTO Models (ModelID, Make, Model) VALUES (50, 'Nissan', 'Qashqai');

INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('211D1234', 1, 'STD', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('222C5678', 2, 'ECO', 'A', 'D', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('231G9876', 3, 'STD', 'M', 'H', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241K2345', 4, 'STD', 'A', 'E', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('211L8765', 5, 'STD', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('222M4321', 6, 'ECO', 'A', 'D', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('231MH5678', 7, 'LUX', 'M', 'H', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241S9876', 8, 'LUX', 'A', 'E', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('212CN5678', 13, 'ECO', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('221CW9876', 14, 'ECO', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('232KY2345', 15, 'ECO', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241L8765', 16, 'ECO', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('212LD4321', 17, 'SPT', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('221LH5678', 18, 'SPT', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('232MO9876', 19, 'SPT', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241OY1234', 20, 'SPT', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('212RN5678', 21, 'SPT', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('221T8765', 22, 'STD', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('231W2345', 23, 'STD', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241WH5678', 24, 'LUX', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('212D9876', 25, 'LUX', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('222KE1234', 26, 'LUX', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('231MO5678', 27, 'LUX', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241C8765', 28, 'LUX', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('212CW4321', 29, 'ECO', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('221D5678', 30, 'ECO', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('232DL9876', 31, 'STD', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241D2345', 32, 'STD', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('212MH8765', 33, 'ECO', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('222LD4321', 34, 'STD', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('232T5678', 35, 'GRN', 'A', 'E', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241OY9876', 36, 'GRN', 'A', 'E', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('212G1234', 37, 'GRN', 'A', 'E', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('222KE5678', 38, 'SUV', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('231C8765', 39, 'GRN', 'A', 'H', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241KY2345', 40, 'GRN', 'A', 'H', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('212KK5678', 41, 'GRN', 'A', 'H', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('221LH8765', 42, 'SUV', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('231L2345', 43, 'SUV', 'A', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241L5678', 44, 'SUV', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('212LK9876', 45, 'MNV', 'A', 'D', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('221L1234', 46, 'MNV', 'M', 'D', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('232MN5678', 47, 'MNV', 'A', 'D', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241OY8765', 48, 'MNV', 'M', 'D', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('212MH2345', 49, 'MNV', 'A', 'D', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('222OY5678', 49, 'SUV', 'A', 'D', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('231RN8765', 49, 'SUV', 'M', 'P', 'D');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('241LD2345', 50, 'SUV', 'A', 'D', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('212T5678', 50, 'SUV', 'M', 'P', 'A');
INSERT INTO Vehicles (RegNum, ModelID, TypeCode, Trans, Fuel, Avail) VALUES ('231WD2345', 50, 'SUV', 'A', 'D', 'D');



INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, ActReturnDate, Cost, Status, License)
VALUES ('11001', 'John', 'Doe', 'john.doe@email.com', '14133740856', '221D5678', TO_DATE('03-FEB-23', 'DD-MON-YY'), TO_DATE('05-FEB-23', 'DD-MON-YY'), TO_DATE('10-FEB-23', 'DD-MON-YY'),  TO_DATE('10-FEB-23', 'DD-MON-YY'), 240.00, 'D', 'G5368072');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, ActReturnDate, Cost, Status, License)
VALUES ('11002', 'Maria', 'Rodriguez', 'maria.rodriguez@email.com', '346789077623', '222C5678', TO_DATE('04-FEB-24', 'DD-MON-YY'), TO_DATE('08-FEB-24', 'DD-MON-YY'), TO_DATE('12-FEB-24', 'DD-MON-YY'), TO_DATE('12-FEB-24', 'DD-MON-YY'), 150.00, 'D', '53733072');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11003', 'Akio', 'Tanaka', 'akio.tanaka@email.com', '81345485933', '231G9876', TO_DATE('06-FEB-24', 'DD-MON-YY'), TO_DATE('08-FEB-24', 'DD-MON-YY'), TO_DATE('14-FEB-24', 'DD-MON-YY'), 280.00, 'C');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, ActReturnDate, Cost, Status, License)
VALUES ('11004', 'Sofia', 'Gomez', 'sofia.gomez@email.com', '57321345480', '241K2345', TO_DATE('08-FEB-24', 'DD-MON-YY'), TO_DATE('10-FEB-24', 'DD-MON-YY'), TO_DATE('15-FEB-24', 'DD-MON-YY'), TO_DATE('15-FEB-24', 'DD-MON-YY'), 270.00, 'P', 'G5368072');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, ActReturnDate, Cost, Status, License)
VALUES ('11005', 'Makoto', 'Sato', 'makoto.sato@email.com', '81345678901', '211L8765', TO_DATE('10-FEB-23', 'DD-MON-YY'), TO_DATE('15-MAR-23', 'DD-MON-YY'), TO_DATE('20-MAR-23', 'DD-MON-YY'), TO_DATE('20-MAR-23', 'DD-MON-YY'), 240.00, 'D', '73RY3072');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11006', 'Ellen', 'Ivans', 'ellen.ivans@email.com', '27829224597', '222M4321', TO_DATE('12-FEB-24', 'DD-MON-YY'), TO_DATE('15-FEB-24', 'DD-MON-YY'), TO_DATE('20-FEB-24', 'DD-MON-YY'), 180.00, 'R');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11007', 'Mohammed', 'Al-Farsi', 'mohammed.alfarsi@email.com', '9665283095', '231MH5678', TO_DATE('15-FEB-24', 'DD-MON-YY'), TO_DATE('18-FEB-24', 'DD-MON-YY'), TO_DATE('25-FEB-24', 'DD-MON-YY'), 640.00, 'R');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11008', 'Sophie', 'Lefevre', 'sophie.lefevre@email.com', '33193554708', '241S9876', TO_DATE('20-FEB-24', 'DD-MON-YY'), TO_DATE('22-FEB-24', 'DD-MON-YY'), TO_DATE('28-FEB-24', 'DD-MON-YY'), 315.00, 'C');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status, License)
VALUES ('11009', 'Carlos', 'Rodriguez', 'carlos.rodriguez@email.com', '34678169803', '221L1234', TO_DATE('22-FEB-24', 'DD-MON-YY'), TO_DATE('25-FEB-24', 'DD-MON-YY'), TO_DATE('01-MAR-24', 'DD-MON-YY'), 240.00, 'P', '865II3072');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, ActReturnDate, Cost, Status, License)
VALUES ('11010', 'Yuki', 'Takahashi', 'yuki.takahashi@email.com', '81345678901', '212T5678', TO_DATE('25-FEB-24', 'DD-MON-YY'), TO_DATE('28-FEB-24', 'DD-MON-YY'), TO_DATE('05-MAR-24', 'DD-MON-YY'), TO_DATE('05-MAR-24', 'DD-MON-YY'), 210.00, 'D', 'TGY3072');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11011', 'Jennifer', 'Smith', 'jennifer.smith@email.com', '141189234785', '232KY2345', TO_DATE('01-MAR-24', 'DD-MON-YY'), TO_DATE('05-MAR-24', 'DD-MON-YY'), TO_DATE('10-MAR-24', 'DD-MON-YY'), 420.00, 'R');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11012', 'Michael', 'Johnson', 'michael.johnson@email.com', '14155558901', '241L8765', TO_DATE('05-MAR-24', 'DD-MON-YY'), TO_DATE('08-MAR-24', 'DD-MON-YY'), TO_DATE('15-MAR-24', 'DD-MON-YY'), 360.00, 'R');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11013', 'Christopher', 'Davis', 'christopher.davis@email.com', '141270589', '212LD4321', TO_DATE('10-MAR-24', 'DD-MON-YY'), TO_DATE('12-MAR-24', 'DD-MON-YY'), TO_DATE('18-MAR-24', 'DD-MON-YY'), 280.00, 'C');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status, License)
VALUES ('11014', 'Amanda', 'Miller', 'amanda.miller@email.com', '14153860394', '221LH5678', TO_DATE('12-MAR-24', 'DD-MON-YY'), TO_DATE('15-MAR-24', 'DD-MON-YY'), TO_DATE('20-MAR-24', 'DD-MON-YY'), 240.00, 'P', '7OOR3072');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, ActReturnDate, Cost, Status, License)
VALUES ('11015', 'Matthew', 'Brown', 'matthew.brown@email.com', '1415708637', '232MO9876', TO_DATE('15-MAR-24', 'DD-MON-YY'), TO_DATE('20-MAR-23', 'DD-MON-YY'), TO_DATE('25-MAR-23', 'DD-MON-YY'), TO_DATE('25-MAR-23', 'DD-MON-YY'), 270.00, 'D', 'TRY23072');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11016', 'Emily', 'Anderson', 'emily.anderson@email.com', '14153780686', '241OY1234', TO_DATE('20-MAR-24', 'DD-MON-YY'), TO_DATE('22-MAR-24', 'DD-MON-YY'), TO_DATE('28-MAR-24', 'DD-MON-YY'), 315.00, 'R');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11017', 'Daniel', 'Clark', 'daniel.clark@email.com', '1413467678', '212RN5678', TO_DATE('22-MAR-24', 'DD-MON-YY'), TO_DATE('25-MAR-24', 'DD-MON-YY'), TO_DATE('30-MAR-24', 'DD-MON-YY'), 240.00, 'R');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11018', 'Jessica', 'Ward', 'jessica.ward@email.com', '1419039012', '221T8765', TO_DATE('28-MAR-24', 'DD-MON-YY'), TO_DATE('30-MAR-24', 'DD-MON-YY'), TO_DATE('05-APR-24', 'DD-MON-YY'), 280.00, 'C');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status, License)
VALUES ('11019', 'Christopher', 'Evans', 'chris.evans@email.com', '14164692295', '231W2345', TO_DATE('30-MAR-24', 'DD-MON-YY'), TO_DATE('02-APR-24', 'DD-MON-YY'), TO_DATE('07-APR-24', 'DD-MON-YY'), 480.00, 'P', 'OW333072');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, ActReturnDate, Cost, Status, License)
VALUES ('11020', 'Rachel', 'Harrison', 'rachel.harrison@email.com', '14154259626', '241WH5678', TO_DATE('02-APR-24', 'DD-MON-YY'), TO_DATE('05-APR-24', 'DD-MON-YY'), TO_DATE('10-APR-24', 'DD-MON-YY'), TO_DATE('10-APR-24', 'DD-MON-YY'), 270.00, 'D', '1234GI99');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11021', 'Anna', 'Schmidt', 'anna.schmidt@email.com', '49153485489', '212D9876', TO_DATE('05-APR-24', 'DD-MON-YY'), TO_DATE('11-APR-24', 'DD-MON-YY'), TO_DATE('15-APR-24', 'DD-MON-YY'), 320.00, 'R');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11022', 'Maximilian', 'Mueller', 'max.mueller@email.com', '4915790686', '222KE1234', TO_DATE('08-APR-24', 'DD-MON-YY'), TO_DATE('11-APR-24', 'DD-MON-YY'), TO_DATE('17-APR-24', 'DD-MON-YY'), 240.00, 'R');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11023', 'Sophie', 'Becker', 'sophie.becker@email.com', '491576937439', '232DL9876', TO_DATE('15-APR-24', 'DD-MON-YY'), TO_DATE('18-APR-24', 'DD-MON-YY'), TO_DATE('25-APR-24', 'DD-MON-YY'), 320.00, 'C');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status, License)
VALUES ('11024', 'Hans', 'Wagner', 'hans.wagner@email.com', '4915790286', '241D2345', TO_DATE('18-APR-24', 'DD-MON-YY'), TO_DATE('20-APR-24', 'DD-MON-YY'), TO_DATE('27-APR-24', 'DD-MON-YY'), 360.00, 'P', '73RY3876');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, ActReturnDate, Cost, Status, License)
VALUES ('11025', 'Lena', 'Schulz', 'lena.schulz@email.com', '491558434570', '212MH8765', TO_DATE('20-APR-24', 'DD-MON-YY'), TO_DATE('25-JUN-23', 'DD-MON-YY'), TO_DATE('30-JUN-23', 'DD-MON-YY'), TO_DATE('30-JUN-23', 'DD-MON-YY'), 240.00, 'D', '7Q1RY372');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11026', 'Sophie', 'Becker', 'sophie.becker@email.com', '491553498760', '232DL9876', TO_DATE('15-JUN-24', 'DD-MON-YY'), TO_DATE('18-JUN-24', 'DD-MON-YY'), TO_DATE('25-JUN-24', 'DD-MON-YY'), 320.00, 'C');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11027', 'Elin', 'Larsson', 'elin.larsson@email.com', '467089067089', '232T5678', TO_DATE('05-MAY-24', 'DD-MON-YY'), TO_DATE('08-MAY-24', 'DD-MON-YY'), TO_DATE('15-MAY-24', 'DD-MON-YY'), 360.00, 'R');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11028', 'Sven', 'Andersen', 'sven.andersen@email.com', '46708904068', '241OY9876', TO_DATE('15-MAY-24', 'DD-MON-YY'), TO_DATE('18-MAY-24', 'DD-MON-YY'), TO_DATE('25-MAY-24', 'DD-MON-YY'), 360.00, 'C');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status, License)
VALUES ('11029', 'Hanna', 'Johansson', 'hanna.johansson@email.com', '467072395578', '212G1234', TO_DATE('18-MAY-24', 'DD-MON-YY'), TO_DATE('20-MAY-24', 'DD-MON-YY'), TO_DATE('27-MAY-24', 'DD-MON-YY'), 320.00, 'P', '22FFFF72');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11030', 'Lars', 'Olsen', 'lars.olsen@email.com', '468903656739', '222KE5678', TO_DATE('20-SEP-24', 'DD-MON-YY'), TO_DATE('25-SEP-24', 'DD-MON-YY'), TO_DATE('30-SEP-24', 'DD-MON-YY'), 180.00, 'R');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, Cost, Status)
VALUES ('11031', 'Alex', 'Johnson', 'alex.johnson@email.com', '14153751034', '211D1234', TO_DATE('01-JUN-24', 'DD-MON-YY'), TO_DATE('05-JUN-24', 'DD-MON-YY'), TO_DATE('10-JUN-24', 'DD-MON-YY'), 240.00, 'R');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, ActReturnDate, Cost, Status, License)
VALUES ('11032', 'Emma', 'Miller', 'emma.miller@email.com', '14155857369', '232KY2345', TO_DATE('05-JUL-23', 'DD-MON-YY'), TO_DATE('08-JUL-23', 'DD-MON-YY'), TO_DATE('15-JUL-23', 'DD-MON-YY'), TO_DATE('15-JUL-23', 'DD-MON-YY'), 560.00, 'D', '22G8FF72');
INSERT INTO Reservations (ResID, FName, Sname, Email, Phone, RegNum, ResDate, PickupDate, ReturnDate, ActReturnDate, Cost, Status, License)
VALUES ('11033', 'Max', 'Weber', 'max.weber@email.com', '9155665484', '222KE1234', TO_DATE('10-AUG-23', 'DD-MON-YY'), TO_DATE('15-AUG-23', 'DD-MON-YY'), TO_DATE('20-AUG-23', 'DD-MON-YY'), TO_DATE('20-AUG-23', 'DD-MON-YY'), 180.00, 'D', '225J5372');



COMMIT;

