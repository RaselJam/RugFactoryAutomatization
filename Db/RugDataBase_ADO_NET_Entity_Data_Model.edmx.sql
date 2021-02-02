
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/30/2020 23:45:17
-- Generated from EDMX file: C:\Users\Alicia\source\repos\RugFactory\Db\RugDataBase_ADO_NET_Entity_Data_Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RugsDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AlfombraFalloAlfombra_Alfombra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlfombraFalloAlfombra] DROP CONSTRAINT [FK_AlfombraFalloAlfombra_Alfombra];
GO
IF OBJECT_ID(N'[dbo].[FK_AlfombraFalloAlfombra_FalloAlfombra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlfombraFalloAlfombra] DROP CONSTRAINT [FK_AlfombraFalloAlfombra_FalloAlfombra];
GO
IF OBJECT_ID(N'[dbo].[FK_AlfombraCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Alfombras] DROP CONSTRAINT [FK_AlfombraCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteAlbaran]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Albaranes] DROP CONSTRAINT [FK_ClienteAlbaran];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Facturas] DROP CONSTRAINT [FK_ClienteFactura];
GO
IF OBJECT_ID(N'[dbo].[FK_AlbaranFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Facturas] DROP CONSTRAINT [FK_AlbaranFactura];
GO
IF OBJECT_ID(N'[dbo].[FK_AlbaranAlfombra_Albaran]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlbaranAlfombra] DROP CONSTRAINT [FK_AlbaranAlfombra_Albaran];
GO
IF OBJECT_ID(N'[dbo].[FK_AlbaranAlfombra_Alfombra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlbaranAlfombra] DROP CONSTRAINT [FK_AlbaranAlfombra_Alfombra];
GO
IF OBJECT_ID(N'[dbo].[FK_FacturaAlfombra_Factura]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FacturaAlfombra] DROP CONSTRAINT [FK_FacturaAlfombra_Factura];
GO
IF OBJECT_ID(N'[dbo].[FK_FacturaAlfombra_Alfombra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FacturaAlfombra] DROP CONSTRAINT [FK_FacturaAlfombra_Alfombra];
GO
IF OBJECT_ID(N'[dbo].[FK_LavadoAlfombra_Lavado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LavadoAlfombra] DROP CONSTRAINT [FK_LavadoAlfombra_Lavado];
GO
IF OBJECT_ID(N'[dbo].[FK_LavadoAlfombra_Alfombra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LavadoAlfombra] DROP CONSTRAINT [FK_LavadoAlfombra_Alfombra];
GO
IF OBJECT_ID(N'[dbo].[FK_LavadoAlbaran_Lavado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LavadoAlbaran] DROP CONSTRAINT [FK_LavadoAlbaran_Lavado];
GO
IF OBJECT_ID(N'[dbo].[FK_LavadoAlbaran_Albaran]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LavadoAlbaran] DROP CONSTRAINT [FK_LavadoAlbaran_Albaran];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Alfombras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alfombras];
GO
IF OBJECT_ID(N'[dbo].[FallosAlfombra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FallosAlfombra];
GO
IF OBJECT_ID(N'[dbo].[Albaranes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Albaranes];
GO
IF OBJECT_ID(N'[dbo].[Facturas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Facturas];
GO
IF OBJECT_ID(N'[dbo].[Lavados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lavados];
GO
IF OBJECT_ID(N'[dbo].[AlfombraFalloAlfombra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlfombraFalloAlfombra];
GO
IF OBJECT_ID(N'[dbo].[AlbaranAlfombra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlbaranAlfombra];
GO
IF OBJECT_ID(N'[dbo].[FacturaAlfombra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FacturaAlfombra];
GO
IF OBJECT_ID(N'[dbo].[LavadoAlfombra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LavadoAlfombra];
GO
IF OBJECT_ID(N'[dbo].[LavadoAlbaran]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LavadoAlbaran];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Cliente_Id] int IDENTITY(1,1) NOT NULL,
    [Nombre_Apellidos] nvarchar(50)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Movile] nvarchar(20)  NOT NULL,
    [Telefono] nvarchar(20)  NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Alfombras'
CREATE TABLE [dbo].[Alfombras] (
    [Alfombra_Id] int IDENTITY(1,1) NOT NULL,
    [Ancho] smallint  NOT NULL,
    [Largo] smallint  NOT NULL,
    [Calidad] nvarchar(max)  NOT NULL,
    [ClienteCliente_Id] int  NOT NULL,
    [Is_EnFabrica] bit  NOT NULL,
    [Is_Lavado] bit  NULL,
    [Prefix_Albaran] nvarchar(max)  NULL
);
GO

-- Creating table 'FallosAlfombra'
CREATE TABLE [dbo].[FallosAlfombra] (
    [FalloId] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(20)  NOT NULL,
    [Descripcion] nvarchar(500)  NULL
);
GO

-- Creating table 'Albaranes'
CREATE TABLE [dbo].[Albaranes] (
    [Albaran_Id] int IDENTITY(1,1) NOT NULL,
    [Recogido_Por] nvarchar(10)  NOT NULL,
    [Fecha_Entrada] datetime  NULL,
    [Foto_Job] nvarchar(50)  NULL,
    [Fecha_BaseDatos] datetime  NULL,
    [Presupuesto] nvarchar(max)  NULL,
    [Is_Confirmado] bit  NOT NULL,
    [Is_Trabajo_Terminado] bit  NOT NULL,
    [ClienteCliente_Id] int  NOT NULL,
    [Parte_Confirmado] nvarchar(max)  NULL,
    [Total_Items_Quantity] smallint  NULL,
    [Numero_Albaran] nvarchar(max)  NOT NULL,
    [Is_Active] bit  NOT NULL,
    [NumeroDeAviso] nvarchar(20)  NOT NULL,
    [fecha_Estimada] datetime  NULL
);
GO

-- Creating table 'Facturas'
CREATE TABLE [dbo].[Facturas] (
    [Fatura_Id] int IDENTITY(1,1) NOT NULL,
    [Total] smallint  NOT NULL,
    [Is_Cobrado] bit  NOT NULL,
    [Metodo_Pago] nvarchar(20)  NULL,
    [Fecha_Emicion] datetime  NOT NULL,
    [Fecha_Entrega] datetime  NOT NULL,
    [ClienteCliente_Id] int  NOT NULL,
    [Entregado_Por] nvarchar(50)  NULL,
    [ContactContact_Id] int  NOT NULL,
    [Is_Entregado] nvarchar(max)  NOT NULL,
    [Descuento] smallint  NOT NULL,
    [Albaran_Albaran_Id] int  NULL
);
GO

-- Creating table 'Lavados'
CREATE TABLE [dbo].[Lavados] (
    [Lavado_Id] int IDENTITY(1,1) NOT NULL,
    [Personal] nvarchar(100)  NOT NULL,
    [Fecha] datetime  NOT NULL
);
GO

-- Creating table 'AlfombraFalloAlfombra'
CREATE TABLE [dbo].[AlfombraFalloAlfombra] (
    [AlfombraFalloAlfombra_FalloAlfombra_Alfombra_Id] int  NOT NULL,
    [FalloAlfombras_FalloId] int  NOT NULL
);
GO

-- Creating table 'AlbaranAlfombra'
CREATE TABLE [dbo].[AlbaranAlfombra] (
    [Albarans_Albaran_Id] int  NOT NULL,
    [Alfombras_Alfombra_Id] int  NOT NULL
);
GO

-- Creating table 'FacturaAlfombra'
CREATE TABLE [dbo].[FacturaAlfombra] (
    [FacturaAlfombra_Alfombra_Fatura_Id] int  NOT NULL,
    [Alfombras_Alfombra_Id] int  NOT NULL
);
GO

-- Creating table 'LavadoAlfombra'
CREATE TABLE [dbo].[LavadoAlfombra] (
    [Lavados_Lavado_Id] int  NOT NULL,
    [Alfombras_Alfombra_Id] int  NOT NULL
);
GO

-- Creating table 'LavadoAlbaran'
CREATE TABLE [dbo].[LavadoAlbaran] (
    [Lavados_Lavado_Id] int  NOT NULL,
    [Albarans_Albaran_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Cliente_Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Cliente_Id] ASC);
GO

-- Creating primary key on [Alfombra_Id] in table 'Alfombras'
ALTER TABLE [dbo].[Alfombras]
ADD CONSTRAINT [PK_Alfombras]
    PRIMARY KEY CLUSTERED ([Alfombra_Id] ASC);
GO

-- Creating primary key on [FalloId] in table 'FallosAlfombra'
ALTER TABLE [dbo].[FallosAlfombra]
ADD CONSTRAINT [PK_FallosAlfombra]
    PRIMARY KEY CLUSTERED ([FalloId] ASC);
GO

-- Creating primary key on [Albaran_Id] in table 'Albaranes'
ALTER TABLE [dbo].[Albaranes]
ADD CONSTRAINT [PK_Albaranes]
    PRIMARY KEY CLUSTERED ([Albaran_Id] ASC);
GO

-- Creating primary key on [Fatura_Id] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [PK_Facturas]
    PRIMARY KEY CLUSTERED ([Fatura_Id] ASC);
GO

-- Creating primary key on [Lavado_Id] in table 'Lavados'
ALTER TABLE [dbo].[Lavados]
ADD CONSTRAINT [PK_Lavados]
    PRIMARY KEY CLUSTERED ([Lavado_Id] ASC);
GO

-- Creating primary key on [AlfombraFalloAlfombra_FalloAlfombra_Alfombra_Id], [FalloAlfombras_FalloId] in table 'AlfombraFalloAlfombra'
ALTER TABLE [dbo].[AlfombraFalloAlfombra]
ADD CONSTRAINT [PK_AlfombraFalloAlfombra]
    PRIMARY KEY CLUSTERED ([AlfombraFalloAlfombra_FalloAlfombra_Alfombra_Id], [FalloAlfombras_FalloId] ASC);
GO

-- Creating primary key on [Albarans_Albaran_Id], [Alfombras_Alfombra_Id] in table 'AlbaranAlfombra'
ALTER TABLE [dbo].[AlbaranAlfombra]
ADD CONSTRAINT [PK_AlbaranAlfombra]
    PRIMARY KEY CLUSTERED ([Albarans_Albaran_Id], [Alfombras_Alfombra_Id] ASC);
GO

-- Creating primary key on [FacturaAlfombra_Alfombra_Fatura_Id], [Alfombras_Alfombra_Id] in table 'FacturaAlfombra'
ALTER TABLE [dbo].[FacturaAlfombra]
ADD CONSTRAINT [PK_FacturaAlfombra]
    PRIMARY KEY CLUSTERED ([FacturaAlfombra_Alfombra_Fatura_Id], [Alfombras_Alfombra_Id] ASC);
GO

-- Creating primary key on [Lavados_Lavado_Id], [Alfombras_Alfombra_Id] in table 'LavadoAlfombra'
ALTER TABLE [dbo].[LavadoAlfombra]
ADD CONSTRAINT [PK_LavadoAlfombra]
    PRIMARY KEY CLUSTERED ([Lavados_Lavado_Id], [Alfombras_Alfombra_Id] ASC);
GO

-- Creating primary key on [Lavados_Lavado_Id], [Albarans_Albaran_Id] in table 'LavadoAlbaran'
ALTER TABLE [dbo].[LavadoAlbaran]
ADD CONSTRAINT [PK_LavadoAlbaran]
    PRIMARY KEY CLUSTERED ([Lavados_Lavado_Id], [Albarans_Albaran_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AlfombraFalloAlfombra_FalloAlfombra_Alfombra_Id] in table 'AlfombraFalloAlfombra'
ALTER TABLE [dbo].[AlfombraFalloAlfombra]
ADD CONSTRAINT [FK_AlfombraFalloAlfombra_Alfombra]
    FOREIGN KEY ([AlfombraFalloAlfombra_FalloAlfombra_Alfombra_Id])
    REFERENCES [dbo].[Alfombras]
        ([Alfombra_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FalloAlfombras_FalloId] in table 'AlfombraFalloAlfombra'
ALTER TABLE [dbo].[AlfombraFalloAlfombra]
ADD CONSTRAINT [FK_AlfombraFalloAlfombra_FalloAlfombra]
    FOREIGN KEY ([FalloAlfombras_FalloId])
    REFERENCES [dbo].[FallosAlfombra]
        ([FalloId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlfombraFalloAlfombra_FalloAlfombra'
CREATE INDEX [IX_FK_AlfombraFalloAlfombra_FalloAlfombra]
ON [dbo].[AlfombraFalloAlfombra]
    ([FalloAlfombras_FalloId]);
GO

-- Creating foreign key on [ClienteCliente_Id] in table 'Alfombras'
ALTER TABLE [dbo].[Alfombras]
ADD CONSTRAINT [FK_AlfombraCliente]
    FOREIGN KEY ([ClienteCliente_Id])
    REFERENCES [dbo].[Clientes]
        ([Cliente_Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlfombraCliente'
CREATE INDEX [IX_FK_AlfombraCliente]
ON [dbo].[Alfombras]
    ([ClienteCliente_Id]);
GO

-- Creating foreign key on [ClienteCliente_Id] in table 'Albaranes'
ALTER TABLE [dbo].[Albaranes]
ADD CONSTRAINT [FK_ClienteAlbaran]
    FOREIGN KEY ([ClienteCliente_Id])
    REFERENCES [dbo].[Clientes]
        ([Cliente_Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteAlbaran'
CREATE INDEX [IX_FK_ClienteAlbaran]
ON [dbo].[Albaranes]
    ([ClienteCliente_Id]);
GO

-- Creating foreign key on [ClienteCliente_Id] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [FK_ClienteFactura]
    FOREIGN KEY ([ClienteCliente_Id])
    REFERENCES [dbo].[Clientes]
        ([Cliente_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFactura'
CREATE INDEX [IX_FK_ClienteFactura]
ON [dbo].[Facturas]
    ([ClienteCliente_Id]);
GO

-- Creating foreign key on [Albaran_Albaran_Id] in table 'Facturas'
ALTER TABLE [dbo].[Facturas]
ADD CONSTRAINT [FK_AlbaranFactura]
    FOREIGN KEY ([Albaran_Albaran_Id])
    REFERENCES [dbo].[Albaranes]
        ([Albaran_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlbaranFactura'
CREATE INDEX [IX_FK_AlbaranFactura]
ON [dbo].[Facturas]
    ([Albaran_Albaran_Id]);
GO

-- Creating foreign key on [Albarans_Albaran_Id] in table 'AlbaranAlfombra'
ALTER TABLE [dbo].[AlbaranAlfombra]
ADD CONSTRAINT [FK_AlbaranAlfombra_Albaran]
    FOREIGN KEY ([Albarans_Albaran_Id])
    REFERENCES [dbo].[Albaranes]
        ([Albaran_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Alfombras_Alfombra_Id] in table 'AlbaranAlfombra'
ALTER TABLE [dbo].[AlbaranAlfombra]
ADD CONSTRAINT [FK_AlbaranAlfombra_Alfombra]
    FOREIGN KEY ([Alfombras_Alfombra_Id])
    REFERENCES [dbo].[Alfombras]
        ([Alfombra_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlbaranAlfombra_Alfombra'
CREATE INDEX [IX_FK_AlbaranAlfombra_Alfombra]
ON [dbo].[AlbaranAlfombra]
    ([Alfombras_Alfombra_Id]);
GO

-- Creating foreign key on [FacturaAlfombra_Alfombra_Fatura_Id] in table 'FacturaAlfombra'
ALTER TABLE [dbo].[FacturaAlfombra]
ADD CONSTRAINT [FK_FacturaAlfombra_Factura]
    FOREIGN KEY ([FacturaAlfombra_Alfombra_Fatura_Id])
    REFERENCES [dbo].[Facturas]
        ([Fatura_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Alfombras_Alfombra_Id] in table 'FacturaAlfombra'
ALTER TABLE [dbo].[FacturaAlfombra]
ADD CONSTRAINT [FK_FacturaAlfombra_Alfombra]
    FOREIGN KEY ([Alfombras_Alfombra_Id])
    REFERENCES [dbo].[Alfombras]
        ([Alfombra_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacturaAlfombra_Alfombra'
CREATE INDEX [IX_FK_FacturaAlfombra_Alfombra]
ON [dbo].[FacturaAlfombra]
    ([Alfombras_Alfombra_Id]);
GO

-- Creating foreign key on [Lavados_Lavado_Id] in table 'LavadoAlfombra'
ALTER TABLE [dbo].[LavadoAlfombra]
ADD CONSTRAINT [FK_LavadoAlfombra_Lavado]
    FOREIGN KEY ([Lavados_Lavado_Id])
    REFERENCES [dbo].[Lavados]
        ([Lavado_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Alfombras_Alfombra_Id] in table 'LavadoAlfombra'
ALTER TABLE [dbo].[LavadoAlfombra]
ADD CONSTRAINT [FK_LavadoAlfombra_Alfombra]
    FOREIGN KEY ([Alfombras_Alfombra_Id])
    REFERENCES [dbo].[Alfombras]
        ([Alfombra_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LavadoAlfombra_Alfombra'
CREATE INDEX [IX_FK_LavadoAlfombra_Alfombra]
ON [dbo].[LavadoAlfombra]
    ([Alfombras_Alfombra_Id]);
GO

-- Creating foreign key on [Lavados_Lavado_Id] in table 'LavadoAlbaran'
ALTER TABLE [dbo].[LavadoAlbaran]
ADD CONSTRAINT [FK_LavadoAlbaran_Lavado]
    FOREIGN KEY ([Lavados_Lavado_Id])
    REFERENCES [dbo].[Lavados]
        ([Lavado_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Albarans_Albaran_Id] in table 'LavadoAlbaran'
ALTER TABLE [dbo].[LavadoAlbaran]
ADD CONSTRAINT [FK_LavadoAlbaran_Albaran]
    FOREIGN KEY ([Albarans_Albaran_Id])
    REFERENCES [dbo].[Albaranes]
        ([Albaran_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LavadoAlbaran_Albaran'
CREATE INDEX [IX_FK_LavadoAlbaran_Albaran]
ON [dbo].[LavadoAlbaran]
    ([Albarans_Albaran_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------