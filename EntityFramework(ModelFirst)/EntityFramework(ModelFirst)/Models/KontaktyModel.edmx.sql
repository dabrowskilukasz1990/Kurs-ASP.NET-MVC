
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/20/2017 21:13:46
-- Generated from EDMX file: F:\Microsoft Visual Studio 2015\Git\Kurs ASP.NET MVC\EntityFramework(ModelFirst)\EntityFramework(ModelFirst)\Models\KontaktyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'KontaktySet'
CREATE TABLE [dbo].[KontaktySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Imie] nvarchar(max)  NOT NULL,
    [Nazwisko] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'KontaktySet'
ALTER TABLE [dbo].[KontaktySet]
ADD CONSTRAINT [PK_KontaktySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------