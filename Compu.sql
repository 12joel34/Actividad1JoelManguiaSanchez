CREATE DATABASE Compu

CREATE TABLE Computadoras (
    ID INT Identity (1,1) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Descripcion TEXT,
    Precio DECIMAL(10, 2) NOT NULL,
    FechaFabricacion DATE NOT NULL,
	PRIMARY KEY (ID),
);
