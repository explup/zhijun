
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/31/2016 22:15:29
-- Generated from EDMX file: G:\code\ZhiJun\ZhiJun\Models\ZhiJun.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Songhong];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CategoryNew]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[News] DROP CONSTRAINT [FK_CategoryNew];
GO
IF OBJECT_ID(N'[dbo].[FK_UniversityInstitute]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Institutes] DROP CONSTRAINT [FK_UniversityInstitute];
GO
IF OBJECT_ID(N'[dbo].[FK_InstituteProgramme]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Programmes] DROP CONSTRAINT [FK_InstituteProgramme];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[News]', 'U') IS NOT NULL
    DROP TABLE [dbo].[News];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[Universities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Universities];
GO
IF OBJECT_ID(N'[dbo].[Programmes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Programmes];
GO
IF OBJECT_ID(N'[dbo].[Institutes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Institutes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'News'
CREATE TABLE [dbo].[News] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Abstract] nvarchar(max)  NOT NULL,
    [Body] nvarchar(max)  NOT NULL,
    [Author] nvarchar(max)  NOT NULL,
    [CreatedDate] datetime  NOT NULL,
    [Category_Id] int  NOT NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Detail] nvarchar(max)  NOT NULL,
    [FromDate] datetime  NOT NULL,
    [ToDate] datetime  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [ContactName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Universities'
CREATE TABLE [dbo].[Universities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Programmes'
CREATE TABLE [dbo].[Programmes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Detail] nvarchar(max)  NOT NULL,
    [StudyOptions] nvarchar(max)  NOT NULL,
    [Lengh] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Requirement] nvarchar(max)  NOT NULL,
    [Level] nvarchar(max)  NOT NULL,
    [Institute_Id] int  NOT NULL
);
GO

-- Creating table 'Institutes'
CREATE TABLE [dbo].[Institutes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [University_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'News'
ALTER TABLE [dbo].[News]
ADD CONSTRAINT [PK_News]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Universities'
ALTER TABLE [dbo].[Universities]
ADD CONSTRAINT [PK_Universities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Programmes'
ALTER TABLE [dbo].[Programmes]
ADD CONSTRAINT [PK_Programmes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Institutes'
ALTER TABLE [dbo].[Institutes]
ADD CONSTRAINT [PK_Institutes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Category_Id] in table 'News'
ALTER TABLE [dbo].[News]
ADD CONSTRAINT [FK_CategoryNew]
    FOREIGN KEY ([Category_Id])
    REFERENCES [dbo].[Categories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoryNew'
CREATE INDEX [IX_FK_CategoryNew]
ON [dbo].[News]
    ([Category_Id]);
GO

-- Creating foreign key on [University_Id] in table 'Institutes'
ALTER TABLE [dbo].[Institutes]
ADD CONSTRAINT [FK_UniversityInstitute]
    FOREIGN KEY ([University_Id])
    REFERENCES [dbo].[Universities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UniversityInstitute'
CREATE INDEX [IX_FK_UniversityInstitute]
ON [dbo].[Institutes]
    ([University_Id]);
GO

-- Creating foreign key on [Institute_Id] in table 'Programmes'
ALTER TABLE [dbo].[Programmes]
ADD CONSTRAINT [FK_InstituteProgramme]
    FOREIGN KEY ([Institute_Id])
    REFERENCES [dbo].[Institutes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InstituteProgramme'
CREATE INDEX [IX_FK_InstituteProgramme]
ON [dbo].[Programmes]
    ([Institute_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------