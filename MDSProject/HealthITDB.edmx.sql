
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2017 10:42:34
-- Generated from EDMX file: C:\Users\DIOGO\Source\Repos\MDSProject\MDSProject\HealthITDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HealthITDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AppointmentConsultationDet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConsultationDetSet] DROP CONSTRAINT [FK_AppointmentConsultationDet];
GO
IF OBJECT_ID(N'[dbo].[FK_DoctorAppointment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AppointmentSet] DROP CONSTRAINT [FK_DoctorAppointment];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DoctorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DoctorSet];
GO
IF OBJECT_ID(N'[dbo].[AppointmentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AppointmentSet];
GO
IF OBJECT_ID(N'[dbo].[ConsultationDetSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConsultationDetSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AppointmentSet'
CREATE TABLE [dbo].[AppointmentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PatientName] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Hour] int  NOT NULL,
    [Doctor_Id] int  NULL,
    [ConsultationDet_Id] int  NULL
);
GO

-- Creating table 'ConsultationDetSet'
CREATE TABLE [dbo].[ConsultationDetSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Symptoms] nvarchar(max)  NOT NULL,
    [Diagnostic] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSet_Doctor'
CREATE TABLE [dbo].[UserSet_Doctor] (
    [Name] nvarchar(max)  NOT NULL,
    [Proficiency] nvarchar(max)  NOT NULL,
    [Ssn] nvarchar(max)  NOT NULL,
    [CheckIn] int  NOT NULL,
    [CheckOut] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'UserSet_HelpDesk'
CREATE TABLE [dbo].[UserSet_HelpDesk] (
    [Name] nvarchar(max)  NOT NULL,
    [CheckIn] int  NOT NULL,
    [CheckOut] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AppointmentSet'
ALTER TABLE [dbo].[AppointmentSet]
ADD CONSTRAINT [PK_AppointmentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ConsultationDetSet'
ALTER TABLE [dbo].[ConsultationDetSet]
ADD CONSTRAINT [PK_ConsultationDetSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet_Doctor'
ALTER TABLE [dbo].[UserSet_Doctor]
ADD CONSTRAINT [PK_UserSet_Doctor]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet_HelpDesk'
ALTER TABLE [dbo].[UserSet_HelpDesk]
ADD CONSTRAINT [PK_UserSet_HelpDesk]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Doctor_Id] in table 'AppointmentSet'
ALTER TABLE [dbo].[AppointmentSet]
ADD CONSTRAINT [FK_DoctorAppointment]
    FOREIGN KEY ([Doctor_Id])
    REFERENCES [dbo].[UserSet_Doctor]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorAppointment'
CREATE INDEX [IX_FK_DoctorAppointment]
ON [dbo].[AppointmentSet]
    ([Doctor_Id]);
GO

-- Creating foreign key on [ConsultationDet_Id] in table 'AppointmentSet'
ALTER TABLE [dbo].[AppointmentSet]
ADD CONSTRAINT [FK_ConsultationDetAppointment]
    FOREIGN KEY ([ConsultationDet_Id])
    REFERENCES [dbo].[ConsultationDetSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultationDetAppointment'
CREATE INDEX [IX_FK_ConsultationDetAppointment]
ON [dbo].[AppointmentSet]
    ([ConsultationDet_Id]);
GO

-- Creating foreign key on [Id] in table 'UserSet_Doctor'
ALTER TABLE [dbo].[UserSet_Doctor]
ADD CONSTRAINT [FK_Doctor_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'UserSet_HelpDesk'
ALTER TABLE [dbo].[UserSet_HelpDesk]
ADD CONSTRAINT [FK_HelpDesk_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------