CREATE DATABASE CompuDB;

CREATE TABLE Computadora (
    ID INT Identity (1,1) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion NVARCHAR (100) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    FechaFabricacion DATE NOT NULL,
	PRIMARY KEY (ID),
);
