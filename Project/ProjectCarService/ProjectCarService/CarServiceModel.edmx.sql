
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/04/2019 00:17:12
-- Generated from EDMX file: D:\Faculty\DotNETNextLevel\Project2\ProjectCarService\ProjectCarService\CarServiceModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AUTO];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientAuto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Autos] DROP CONSTRAINT [FK_ClientAuto];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comands] DROP CONSTRAINT [FK_ClientComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_MaterialDetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Materials] DROP CONSTRAINT [FK_MaterialDetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_OperatieDetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Operations] DROP CONSTRAINT [FK_OperatieDetaliuComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetaliuComandas] DROP CONSTRAINT [FK_DetaliuComandaComanda];
GO
IF OBJECT_ID(N'[dbo].[FK_SasiuAuto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Autos] DROP CONSTRAINT [FK_SasiuAuto];
GO
IF OBJECT_ID(N'[dbo].[FK_DetaliuComandaImagine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Imagines] DROP CONSTRAINT [FK_DetaliuComandaImagine];
GO
IF OBJECT_ID(N'[dbo].[FK_MecanicDetaliuComanda_Mecanic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MecanicDetaliuComanda] DROP CONSTRAINT [FK_MecanicDetaliuComanda_Mecanic];
GO
IF OBJECT_ID(N'[dbo].[FK_MecanicDetaliuComanda_DetaliuComanda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MecanicDetaliuComanda] DROP CONSTRAINT [FK_MecanicDetaliuComanda_DetaliuComanda];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[Autos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autos];
GO
IF OBJECT_ID(N'[dbo].[Sasius]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sasius];
GO
IF OBJECT_ID(N'[dbo].[Mecanics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mecanics];
GO
IF OBJECT_ID(N'[dbo].[Materials]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materials];
GO
IF OBJECT_ID(N'[dbo].[Imagines]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Imagines];
GO
IF OBJECT_ID(N'[dbo].[DetaliuComandas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetaliuComandas];
GO
IF OBJECT_ID(N'[dbo].[Operations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Operations];
GO
IF OBJECT_ID(N'[dbo].[Comands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comands];
GO
IF OBJECT_ID(N'[dbo].[MecanicDetaliuComanda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MecanicDetaliuComanda];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [ClientId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL,
    [Adresa] nvarchar(50)  NOT NULL,
    [Localitate] nvarchar(10)  NOT NULL,
    [Judet] nvarchar(10)  NOT NULL,
    [Telefon] nvarchar(13)  NULL,
    [Email] nvarchar(50)  NULL
);
GO

-- Creating table 'Autos'
CREATE TABLE [dbo].[Autos] (
    [AutoId] int IDENTITY(1,1) NOT NULL,
    [NumarAuto] nvarchar(10)  NOT NULL,
    [SerieSasiu] nvarchar(25)  NOT NULL,
    [ClientClientId] int  NOT NULL,
    [SasiuSasiuId] int  NOT NULL
);
GO

-- Creating table 'Sasius'
CREATE TABLE [dbo].[Sasius] (
    [SasiuId] int IDENTITY(1,1) NOT NULL,
    [CodSasiu] nvarchar(2)  NOT NULL,
    [Denumire] nvarchar(25)  NOT NULL
);
GO

-- Creating table 'Mecanics'
CREATE TABLE [dbo].[Mecanics] (
    [MecanicId] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(15)  NOT NULL,
    [Prenume] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Materials'
CREATE TABLE [dbo].[Materials] (
    [MaterialId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(50)  NOT NULL,
    [Cantitate] decimal(2,0)  NOT NULL,
    [Pret] decimal(2,0)  NOT NULL,
    [DataAprovizionare] datetimeoffset  NOT NULL,
    [DetaliuComanda_DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'Imagines'
CREATE TABLE [dbo].[Imagines] (
    [ImagineId] int IDENTITY(1,1) NOT NULL,
    [Titlu] nvarchar(15)  NOT NULL,
    [Descriere] nvarchar(256)  NOT NULL,
    [Data] datetimeoffset  NOT NULL,
    [Foto] varbinary(max)  NOT NULL,
    [DetaliuComanda_DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'DetaliuComandas'
CREATE TABLE [dbo].[DetaliuComandas] (
    [DetaliuComandaId] int IDENTITY(1,1) NOT NULL,
    [Comanda_ComandaId] int  NOT NULL
);
GO

-- Creating table 'Operations'
CREATE TABLE [dbo].[Operations] (
    [OperatieId] int IDENTITY(1,1) NOT NULL,
    [Denumire] nvarchar(256)  NOT NULL,
    [TimpExecutie] decimal(2,0)  NOT NULL,
    [DetaliuComanda_DetaliuComandaId] int  NOT NULL
);
GO

-- Creating table 'Comands'
CREATE TABLE [dbo].[Comands] (
    [ComandaId] int IDENTITY(1,1) NOT NULL,
    [StareComanda] smallint  NOT NULL,
    [DataSystem] datetime  NOT NULL,
    [DataProgramare] datetime  NOT NULL,
    [DataFinalizare] datetime  NULL,
    [KmBord] int  NULL,
    [Descriere] nvarchar(max)  NOT NULL,
    [ValoarePise] decimal(2,0)  NULL,
    [ClientClientId] int  NOT NULL
);
GO

-- Creating table 'MecanicDetaliuComanda'
CREATE TABLE [dbo].[MecanicDetaliuComanda] (
    [Mecanics_MecanicId] int  NOT NULL,
    [DetaliuComandas_DetaliuComandaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ClientId] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([ClientId] ASC);
GO

-- Creating primary key on [AutoId] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [PK_Autos]
    PRIMARY KEY CLUSTERED ([AutoId] ASC);
GO

-- Creating primary key on [SasiuId] in table 'Sasius'
ALTER TABLE [dbo].[Sasius]
ADD CONSTRAINT [PK_Sasius]
    PRIMARY KEY CLUSTERED ([SasiuId] ASC);
GO

-- Creating primary key on [MecanicId] in table 'Mecanics'
ALTER TABLE [dbo].[Mecanics]
ADD CONSTRAINT [PK_Mecanics]
    PRIMARY KEY CLUSTERED ([MecanicId] ASC);
GO

-- Creating primary key on [MaterialId] in table 'Materials'
ALTER TABLE [dbo].[Materials]
ADD CONSTRAINT [PK_Materials]
    PRIMARY KEY CLUSTERED ([MaterialId] ASC);
GO

-- Creating primary key on [ImagineId] in table 'Imagines'
ALTER TABLE [dbo].[Imagines]
ADD CONSTRAINT [PK_Imagines]
    PRIMARY KEY CLUSTERED ([ImagineId] ASC);
GO

-- Creating primary key on [DetaliuComandaId] in table 'DetaliuComandas'
ALTER TABLE [dbo].[DetaliuComandas]
ADD CONSTRAINT [PK_DetaliuComandas]
    PRIMARY KEY CLUSTERED ([DetaliuComandaId] ASC);
GO

-- Creating primary key on [OperatieId] in table 'Operations'
ALTER TABLE [dbo].[Operations]
ADD CONSTRAINT [PK_Operations]
    PRIMARY KEY CLUSTERED ([OperatieId] ASC);
GO

-- Creating primary key on [ComandaId] in table 'Comands'
ALTER TABLE [dbo].[Comands]
ADD CONSTRAINT [PK_Comands]
    PRIMARY KEY CLUSTERED ([ComandaId] ASC);
GO

-- Creating primary key on [Mecanics_MecanicId], [DetaliuComandas_DetaliuComandaId] in table 'MecanicDetaliuComanda'
ALTER TABLE [dbo].[MecanicDetaliuComanda]
ADD CONSTRAINT [PK_MecanicDetaliuComanda]
    PRIMARY KEY CLUSTERED ([Mecanics_MecanicId], [DetaliuComandas_DetaliuComandaId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClientClientId] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [FK_ClientAuto]
    FOREIGN KEY ([ClientClientId])
    REFERENCES [dbo].[Clients]
        ([ClientId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientAuto'
CREATE INDEX [IX_FK_ClientAuto]
ON [dbo].[Autos]
    ([ClientClientId]);
GO

-- Creating foreign key on [ClientClientId] in table 'Comands'
ALTER TABLE [dbo].[Comands]
ADD CONSTRAINT [FK_ClientComanda]
    FOREIGN KEY ([ClientClientId])
    REFERENCES [dbo].[Clients]
        ([ClientId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientComanda'
CREATE INDEX [IX_FK_ClientComanda]
ON [dbo].[Comands]
    ([ClientClientId]);
GO

-- Creating foreign key on [DetaliuComanda_DetaliuComandaId] in table 'Materials'
ALTER TABLE [dbo].[Materials]
ADD CONSTRAINT [FK_MaterialDetaliuComanda]
    FOREIGN KEY ([DetaliuComanda_DetaliuComandaId])
    REFERENCES [dbo].[DetaliuComandas]
        ([DetaliuComandaId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MaterialDetaliuComanda'
CREATE INDEX [IX_FK_MaterialDetaliuComanda]
ON [dbo].[Materials]
    ([DetaliuComanda_DetaliuComandaId]);
GO

-- Creating foreign key on [DetaliuComanda_DetaliuComandaId] in table 'Operations'
ALTER TABLE [dbo].[Operations]
ADD CONSTRAINT [FK_OperatieDetaliuComanda]
    FOREIGN KEY ([DetaliuComanda_DetaliuComandaId])
    REFERENCES [dbo].[DetaliuComandas]
        ([DetaliuComandaId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperatieDetaliuComanda'
CREATE INDEX [IX_FK_OperatieDetaliuComanda]
ON [dbo].[Operations]
    ([DetaliuComanda_DetaliuComandaId]);
GO

-- Creating foreign key on [Comanda_ComandaId] in table 'DetaliuComandas'
ALTER TABLE [dbo].[DetaliuComandas]
ADD CONSTRAINT [FK_DetaliuComandaComanda]
    FOREIGN KEY ([Comanda_ComandaId])
    REFERENCES [dbo].[Comands]
        ([ComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaComanda'
CREATE INDEX [IX_FK_DetaliuComandaComanda]
ON [dbo].[DetaliuComandas]
    ([Comanda_ComandaId]);
GO

-- Creating foreign key on [SasiuSasiuId] in table 'Autos'
ALTER TABLE [dbo].[Autos]
ADD CONSTRAINT [FK_SasiuAuto]
    FOREIGN KEY ([SasiuSasiuId])
    REFERENCES [dbo].[Sasius]
        ([SasiuId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SasiuAuto'
CREATE INDEX [IX_FK_SasiuAuto]
ON [dbo].[Autos]
    ([SasiuSasiuId]);
GO

-- Creating foreign key on [DetaliuComanda_DetaliuComandaId] in table 'Imagines'
ALTER TABLE [dbo].[Imagines]
ADD CONSTRAINT [FK_DetaliuComandaImagine]
    FOREIGN KEY ([DetaliuComanda_DetaliuComandaId])
    REFERENCES [dbo].[DetaliuComandas]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetaliuComandaImagine'
CREATE INDEX [IX_FK_DetaliuComandaImagine]
ON [dbo].[Imagines]
    ([DetaliuComanda_DetaliuComandaId]);
GO

-- Creating foreign key on [Mecanics_MecanicId] in table 'MecanicDetaliuComanda'
ALTER TABLE [dbo].[MecanicDetaliuComanda]
ADD CONSTRAINT [FK_MecanicDetaliuComanda_Mecanic]
    FOREIGN KEY ([Mecanics_MecanicId])
    REFERENCES [dbo].[Mecanics]
        ([MecanicId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DetaliuComandas_DetaliuComandaId] in table 'MecanicDetaliuComanda'
ALTER TABLE [dbo].[MecanicDetaliuComanda]
ADD CONSTRAINT [FK_MecanicDetaliuComanda_DetaliuComanda]
    FOREIGN KEY ([DetaliuComandas_DetaliuComandaId])
    REFERENCES [dbo].[DetaliuComandas]
        ([DetaliuComandaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MecanicDetaliuComanda_DetaliuComanda'
CREATE INDEX [IX_FK_MecanicDetaliuComanda_DetaliuComanda]
ON [dbo].[MecanicDetaliuComanda]
    ([DetaliuComandas_DetaliuComandaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------