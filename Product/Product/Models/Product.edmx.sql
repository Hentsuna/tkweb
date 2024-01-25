
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/13/2023 08:54:02
-- Generated from EDMX file: D:\tkweb\Product\Product\Models\Product.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Product];
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

-- Creating table 'PhongBans'
CREATE TABLE [dbo].[PhongBans] (
    [maphong] int IDENTITY(1,1) NOT NULL,
    [tenphong] nvarchar(max)  NOT NULL,
    [NhanVien_manhanvien] int  NOT NULL
);
GO

-- Creating table 'NhanViens'
CREATE TABLE [dbo].[NhanViens] (
    [manhanvien] int IDENTITY(1,1) NOT NULL,
    [tennhanvien] nvarchar(max)  NOT NULL,
    [maphong] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [maphong] in table 'PhongBans'
ALTER TABLE [dbo].[PhongBans]
ADD CONSTRAINT [PK_PhongBans]
    PRIMARY KEY CLUSTERED ([maphong] ASC);
GO

-- Creating primary key on [manhanvien] in table 'NhanViens'
ALTER TABLE [dbo].[NhanViens]
ADD CONSTRAINT [PK_NhanViens]
    PRIMARY KEY CLUSTERED ([manhanvien] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [NhanVien_manhanvien] in table 'PhongBans'
ALTER TABLE [dbo].[PhongBans]
ADD CONSTRAINT [FK_NhanVienPhongBan]
    FOREIGN KEY ([NhanVien_manhanvien])
    REFERENCES [dbo].[NhanViens]
        ([manhanvien])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NhanVienPhongBan'
CREATE INDEX [IX_FK_NhanVienPhongBan]
ON [dbo].[PhongBans]
    ([NhanVien_manhanvien]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------