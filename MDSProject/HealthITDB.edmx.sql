
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2017 09:17:13
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
    ALTER TABLE [dbo].[AppointmentSet] DROP CONSTRAINT [FK_AppointmentConsultationDet];
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

-- Creating table 'DoctorSet'
CREATE TABLE [dbo].[DoctorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Proficiency] nvarchar(max)  NOT NULL,
    [Ssn] nvarchar(max)  NOT NULL,
    [CheckIn] int  NOT NULL,
    [CheckOut] int  NOT NULL
);
GO

-- Creating table 'AppointmentSet'
CREATE TABLE [dbo].[AppointmentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PatientName] nvarchar(max)  NOT NULL,
    [DoctorName] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Hour] int  NOT NULL,
    [Doctor_Id] int  NULL
);
GO

-- Creating table 'ConsultationDetSet'
CREATE TABLE [dbo].[ConsultationDetSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Symptoms] nvarchar(max)  NOT NULL,
    [Diagnostic] nvarchar(max)  NOT NULL,
    [Appointment_Id] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'DoctorSet'
ALTER TABLE [dbo].[DoctorSet]
ADD CONSTRAINT [PK_DoctorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Appointment_Id] in table 'ConsultationDetSet'
ALTER TABLE [dbo].[ConsultationDetSet]
ADD CONSTRAINT [FK_AppointmentConsultationDet]
    FOREIGN KEY ([Appointment_Id])
    REFERENCES [dbo].[AppointmentSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AppointmentConsultationDet'
CREATE INDEX [IX_FK_AppointmentConsultationDet]
ON [dbo].[ConsultationDetSet]
    ([Appointment_Id]);
GO

-- Creating foreign key on [Doctor_Id] in table 'AppointmentSet'
ALTER TABLE [dbo].[AppointmentSet]
ADD CONSTRAINT [FK_DoctorAppointment]
    FOREIGN KEY ([Doctor_Id])
    REFERENCES [dbo].[DoctorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorAppointment'
CREATE INDEX [IX_FK_DoctorAppointment]
ON [dbo].[AppointmentSet]
    ([Doctor_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------