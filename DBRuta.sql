CREATE DATABASE BDRUTA
USE BDRUTA
-- Crear la tabla de clientes
CREATE TABLE Clientes (
    ID INT PRIMARY KEY,
    Tipo VARCHAR(255) NOT NULL
);

-- Crear la tabla de rutas
CREATE TABLE Rutas (
    ID INT PRIMARY KEY,
    Nombre VARCHAR(255) NOT NULL,
    Precio DECIMAL(5,2) NOT NULL
);




-- Crear la tabla de ventas
CREATE TABLE Ventas (
    ID INT PRIMARY KEY,
    IDCliente INT,
    IDRuta INT,
    CantidadPersonas INT,
    FOREIGN KEY (IDCliente) REFERENCES Clientes(ID),
    FOREIGN KEY (IDRuta) REFERENCES Rutas(ID)
);

-- Agregar registros a la tabla de clientes
INSERT INTO Clientes (ID, Tipo) VALUES 
(1, 'Promoción de colegios'),
(2, 'Adultos mayores de 60 años'),
(3, 'Adultos menores de 60 y jóvenes');

-- Agregar registros a la tabla de rutas
INSERT INTO Rutas (ID, Nombre, Precio) VALUES 
(1, 'Sacsayhuaman - Puka Pukara – Tambomachay', 100.00),
(2, 'Tipon -Lucre-Piquillacta', 120.00),
(3, 'Ollantaytambo-Moray', 150.00);

select * from Ventas
--
