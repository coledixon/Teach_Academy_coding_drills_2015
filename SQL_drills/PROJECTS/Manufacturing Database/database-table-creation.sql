CREATE DATABASE COMPANY;
USE COMPANY;

DROP TABLE IF EXISTS Manufacturers CASCADE;
DROP TABLE IF EXISTS Products;

CREATE TABLE Manufacturers (
        Code INTEGER PRIMARY KEY NOT NULL,
        Name TEXT NOT NULL 
);

CREATE TABLE Products (
        Code INTEGER PRIMARY KEY NOT NULL,
        Name TEXT NOT NULL ,
        Price REAL NOT NULL ,
        Manufacturer INTEGER NOT NULL 
                CONSTRAINT fk_Manufacturers_Code REFERENCES MANUFACTURERS(Code)
);