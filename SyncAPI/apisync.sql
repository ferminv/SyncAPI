IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200304124423_CreacionInicialDB')
BEGIN
    CREATE TABLE [SyncIdentifiers] (
        [Id] uniqueidentifier NOT NULL,
        [Nombre] nvarchar(max) NULL,
        [UltimaFechaActualizacion] datetime2 NOT NULL,
        CONSTRAINT [PK_SyncIdentifiers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200304124423_CreacionInicialDB')
BEGIN
    CREATE TABLE [Articulos] (
        [Id] int NOT NULL IDENTITY,
        [CodigoPereira] nvarchar(max) NULL,
        [PrecioCosto] decimal(18,2) NOT NULL,
        [PrecioUltimaCompra] decimal(18,2) NOT NULL,
        [Precio01] decimal(18,2) NOT NULL,
        [Precio02] decimal(18,2) NOT NULL,
        [Precio03] decimal(18,2) NOT NULL,
        [Precio04] decimal(18,2) NOT NULL,
        [Precio05] decimal(18,2) NOT NULL,
        [Precio06] decimal(18,2) NOT NULL,
        [Precio07] decimal(18,2) NOT NULL,
        [Precio08] decimal(18,2) NOT NULL,
        [Precio09] decimal(18,2) NOT NULL,
        [Precio10] decimal(18,2) NOT NULL,
        [PorcentajeMarcacion] decimal(18,2) NOT NULL,
        [PorcentajeMarcacionDos] decimal(18,2) NOT NULL,
        [PorcentajeMarcacionTres] decimal(18,2) NOT NULL,
        [Porcentaje4] decimal(18,2) NOT NULL,
        [Porcentaje5] decimal(18,2) NOT NULL,
        [Porcentaje6] decimal(18,2) NOT NULL,
        [Porcentaje7] decimal(18,2) NOT NULL,
        [Porcentaje8] decimal(18,2) NOT NULL,
        [Porcentaje9] decimal(18,2) NOT NULL,
        [Porcentaje10] decimal(18,2) NOT NULL,
        [IDSyncIdentifier] uniqueidentifier NULL,
        CONSTRAINT [PK_Articulos] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Articulos_SyncIdentifiers_IDSyncIdentifier] FOREIGN KEY ([IDSyncIdentifier]) REFERENCES [SyncIdentifiers] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200304124423_CreacionInicialDB')
BEGIN
    CREATE INDEX [IX_Articulos_IDSyncIdentifier] ON [Articulos] ([IDSyncIdentifier]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200304124423_CreacionInicialDB')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200304124423_CreacionInicialDB', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311125906_ViendoQueOndaConNavigationPropertys')
BEGIN
    ALTER TABLE [Articulos] DROP CONSTRAINT [FK_Articulos_SyncIdentifiers_IDSyncIdentifier];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311125906_ViendoQueOndaConNavigationPropertys')
BEGIN
    DROP INDEX [IX_Articulos_IDSyncIdentifier] ON [Articulos];
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IDSyncIdentifier');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IDSyncIdentifier] uniqueidentifier NOT NULL;
    CREATE INDEX [IX_Articulos_IDSyncIdentifier] ON [Articulos] ([IDSyncIdentifier]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311125906_ViendoQueOndaConNavigationPropertys')
BEGIN
    ALTER TABLE [Articulos] ADD CONSTRAINT [FK_Articulos_SyncIdentifiers_IDSyncIdentifier] FOREIGN KEY ([IDSyncIdentifier]) REFERENCES [SyncIdentifiers] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200311125906_ViendoQueOndaConNavigationPropertys')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200311125906_ViendoQueOndaConNavigationPropertys', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'PrecioUltimaCompra');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [PrecioUltimaCompra] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'PrecioCosto');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [PrecioCosto] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio10');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Precio10] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio09');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Precio09] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio08');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Precio08] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio07');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Precio07] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio06');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Precio06] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio05');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Precio05] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio04');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Precio04] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio03');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Precio03] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio02');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Precio02] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var12 sysname;
    SELECT @var12 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio01');
    IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var12 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Precio01] decimal(18, 4) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var13 sysname;
    SELECT @var13 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'PorcentajeMarcacionTres');
    IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var13 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [PorcentajeMarcacionTres] decimal(3, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var14 sysname;
    SELECT @var14 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'PorcentajeMarcacionDos');
    IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var14 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [PorcentajeMarcacionDos] decimal(3, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var15 sysname;
    SELECT @var15 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'PorcentajeMarcacion');
    IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var15 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [PorcentajeMarcacion] decimal(3, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var16 sysname;
    SELECT @var16 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje9');
    IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var16 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje9] decimal(3, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var17 sysname;
    SELECT @var17 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje8');
    IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var17 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje8] decimal(3, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var18 sysname;
    SELECT @var18 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje7');
    IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var18 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje7] decimal(3, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var19 sysname;
    SELECT @var19 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje6');
    IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var19 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje6] decimal(3, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var20 sysname;
    SELECT @var20 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje5');
    IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var20 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje5] decimal(3, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var21 sysname;
    SELECT @var21 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje4');
    IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var21 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje4] decimal(3, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    DECLARE @var22 sysname;
    SELECT @var22 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje10');
    IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var22 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje10] decimal(3, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312135707_CambioPrecisionDecimalesArticulo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200312135707_CambioPrecisionDecimalesArticulo', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312142511_CambioPrecisionDecimalesArticulo2')
BEGIN
    DECLARE @var23 sysname;
    SELECT @var23 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'PorcentajeMarcacionTres');
    IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var23 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [PorcentajeMarcacionTres] decimal(6, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312142511_CambioPrecisionDecimalesArticulo2')
BEGIN
    DECLARE @var24 sysname;
    SELECT @var24 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'PorcentajeMarcacionDos');
    IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var24 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [PorcentajeMarcacionDos] decimal(6, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312142511_CambioPrecisionDecimalesArticulo2')
BEGIN
    DECLARE @var25 sysname;
    SELECT @var25 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'PorcentajeMarcacion');
    IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var25 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [PorcentajeMarcacion] decimal(6, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312142511_CambioPrecisionDecimalesArticulo2')
BEGIN
    DECLARE @var26 sysname;
    SELECT @var26 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje9');
    IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var26 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje9] decimal(6, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312142511_CambioPrecisionDecimalesArticulo2')
BEGIN
    DECLARE @var27 sysname;
    SELECT @var27 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje8');
    IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var27 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje8] decimal(6, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312142511_CambioPrecisionDecimalesArticulo2')
BEGIN
    DECLARE @var28 sysname;
    SELECT @var28 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje7');
    IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var28 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje7] decimal(6, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312142511_CambioPrecisionDecimalesArticulo2')
BEGIN
    DECLARE @var29 sysname;
    SELECT @var29 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje6');
    IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var29 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje6] decimal(6, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312142511_CambioPrecisionDecimalesArticulo2')
BEGIN
    DECLARE @var30 sysname;
    SELECT @var30 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje5');
    IF @var30 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var30 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje5] decimal(6, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312142511_CambioPrecisionDecimalesArticulo2')
BEGIN
    DECLARE @var31 sysname;
    SELECT @var31 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje4');
    IF @var31 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var31 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje4] decimal(6, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312142511_CambioPrecisionDecimalesArticulo2')
BEGIN
    DECLARE @var32 sysname;
    SELECT @var32 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje10');
    IF @var32 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var32 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [Porcentaje10] decimal(6, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200312142511_CambioPrecisionDecimalesArticulo2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200312142511_CambioPrecisionDecimalesArticulo2', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var33 sysname;
    SELECT @var33 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje10');
    IF @var33 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var33 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Porcentaje10];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var34 sysname;
    SELECT @var34 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje4');
    IF @var34 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var34 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Porcentaje4];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var35 sysname;
    SELECT @var35 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje5');
    IF @var35 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var35 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Porcentaje5];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var36 sysname;
    SELECT @var36 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje6');
    IF @var36 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var36 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Porcentaje6];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var37 sysname;
    SELECT @var37 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje7');
    IF @var37 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var37 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Porcentaje7];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var38 sysname;
    SELECT @var38 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje8');
    IF @var38 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var38 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Porcentaje8];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var39 sysname;
    SELECT @var39 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Porcentaje9');
    IF @var39 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var39 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Porcentaje9];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var40 sysname;
    SELECT @var40 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'PorcentajeMarcacion');
    IF @var40 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var40 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [PorcentajeMarcacion];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var41 sysname;
    SELECT @var41 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'PorcentajeMarcacionDos');
    IF @var41 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var41 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [PorcentajeMarcacionDos];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var42 sysname;
    SELECT @var42 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio01');
    IF @var42 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var42 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Precio01];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var43 sysname;
    SELECT @var43 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio02');
    IF @var43 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var43 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Precio02];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var44 sysname;
    SELECT @var44 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio03');
    IF @var44 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var44 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Precio03];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var45 sysname;
    SELECT @var45 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio04');
    IF @var45 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var45 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Precio04];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var46 sysname;
    SELECT @var46 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio05');
    IF @var46 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var46 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Precio05];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var47 sysname;
    SELECT @var47 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio06');
    IF @var47 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var47 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Precio06];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var48 sysname;
    SELECT @var48 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio07');
    IF @var48 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var48 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Precio07];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var49 sysname;
    SELECT @var49 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio08');
    IF @var49 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var49 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Precio08];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    DECLARE @var50 sysname;
    SELECT @var50 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'Precio09');
    IF @var50 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var50 + '];');
    ALTER TABLE [Articulos] DROP COLUMN [Precio09];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    EXEC sp_rename N'[Articulos].[PrecioUltimaCompra]', N'UltimoPrecio', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    EXEC sp_rename N'[Articulos].[PrecioCosto]', N'PrecioFranquicia', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    EXEC sp_rename N'[Articulos].[Precio10]', N'PrecioEnOtraMoneda', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    EXEC sp_rename N'[Articulos].[PorcentajeMarcacionTres]', N'PorcentajeIVA', N'COLUMN';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Activo] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [CantidadPromocionFranquicia] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [CertificadoMunicipal] varchar(100) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Codigo01] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Codigo02] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Codigo03] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Codigo04] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Codigo05] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Codigo06] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Codigo07] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Codigo08] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Codigo09] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Codigo10] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [CodigoBarras] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Descripcion] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [DescripcionComponentes] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [DescripcionFranquicia] varchar(300) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [DescripcionWeb] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [ExistenciaActual] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [ExistenciaInicial] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [ExistenciaMinima] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [FechaExistenciaInicial] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [FechaUltimaCompra] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Grados] varchar(100) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IDMoneda] smallint NOT NULL DEFAULT CAST(0 AS smallint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IDMonedaOriginal] smallint NOT NULL DEFAULT CAST(0 AS smallint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IDProveedorUltimaCompra] smallint NOT NULL DEFAULT CAST(0 AS smallint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IDRubro] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IDRubroFranquicia] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IDVendedor] smallint NOT NULL DEFAULT CAST(0 AS smallint);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IdArticuloTransformado] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IdArticuloTransformadoCC] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IdDeposito] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IdFamiliaItemsOrigen] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IdTipoTicket] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IsAVentaFinal] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IsLista4] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IsObligaVencimientoLote] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IsTrasable] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [IsVentaFranquicia] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [NombreLegal] varchar(250) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Observaciones] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [ObservacionesComponentes] varchar(500) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [PAMS] varchar(100) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Peso] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [PesoEspecifico] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [PreNombreLegal] varchar(450) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [PrecioPromocionFranquicia] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [ReporteDefault] varchar(500) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Ubicacion] varchar(300) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [Volumen] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [diasVencimiento] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [fechaServicioDesde] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [fechaServicioHasta] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [idMedida] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [idTipoUnidad] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [isContenedor] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [isDestacado] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [isGenerico] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [isHayQueCorrerFormula] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [isIntermedio] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [isMateriaPrima] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [isProduccion] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [isRetornable] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [isSeguirStock] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [isServicio] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    ALTER TABLE [Articulos] ADD [isSubido] bit NOT NULL DEFAULT CAST(0 AS bit);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    CREATE TABLE [Precios] (
        [Id] int NOT NULL IDENTITY,
        [CodigoPereira] nvarchar(max) NULL,
        [PrecioCosto] decimal(18, 4) NOT NULL,
        [PrecioUltimaCompra] decimal(18, 4) NOT NULL,
        [Precio01] decimal(18, 4) NOT NULL,
        [Precio02] decimal(18, 4) NOT NULL,
        [Precio03] decimal(18, 4) NOT NULL,
        [Precio04] decimal(18, 4) NOT NULL,
        [Precio05] decimal(18, 4) NOT NULL,
        [Precio06] decimal(18, 4) NOT NULL,
        [Precio07] decimal(18, 4) NOT NULL,
        [Precio08] decimal(18, 4) NOT NULL,
        [Precio09] decimal(18, 4) NOT NULL,
        [Precio10] decimal(18, 4) NOT NULL,
        [PorcentajeMarcacion] decimal(6, 2) NOT NULL,
        [PorcentajeMarcacionDos] decimal(6, 2) NOT NULL,
        [PorcentajeMarcacionTres] decimal(6, 2) NOT NULL,
        [Porcentaje4] decimal(6, 2) NOT NULL,
        [Porcentaje5] decimal(6, 2) NOT NULL,
        [Porcentaje6] decimal(6, 2) NOT NULL,
        [Porcentaje7] decimal(6, 2) NOT NULL,
        [Porcentaje8] decimal(6, 2) NOT NULL,
        [Porcentaje9] decimal(6, 2) NOT NULL,
        [Porcentaje10] decimal(6, 2) NOT NULL,
        [IDSyncIdentifier] uniqueidentifier NOT NULL,
        CONSTRAINT [PK_Precios] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Precios_SyncIdentifiers_IDSyncIdentifier] FOREIGN KEY ([IDSyncIdentifier]) REFERENCES [SyncIdentifiers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    CREATE INDEX [IX_Precios_IDSyncIdentifier] ON [Precios] ([IDSyncIdentifier]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200505182339_Articulos')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200505182339_Articulos', N'3.1.2');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var51 sysname;
    SELECT @var51 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'isServicio');
    IF @var51 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var51 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [isServicio] bit NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var52 sysname;
    SELECT @var52 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'isSeguirStock');
    IF @var52 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var52 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [isSeguirStock] bit NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var53 sysname;
    SELECT @var53 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'idTipoUnidad');
    IF @var53 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var53 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [idTipoUnidad] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var54 sysname;
    SELECT @var54 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'idMedida');
    IF @var54 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var54 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [idMedida] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var55 sysname;
    SELECT @var55 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'fechaServicioHasta');
    IF @var55 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var55 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [fechaServicioHasta] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var56 sysname;
    SELECT @var56 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'fechaServicioDesde');
    IF @var56 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var56 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [fechaServicioDesde] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var57 sysname;
    SELECT @var57 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'UltimoPrecio');
    IF @var57 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var57 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [UltimoPrecio] decimal(18, 4) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var58 sysname;
    SELECT @var58 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'PrecioEnOtraMoneda');
    IF @var58 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var58 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [PrecioEnOtraMoneda] decimal(18, 4) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var59 sysname;
    SELECT @var59 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IsLista4');
    IF @var59 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var59 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IsLista4] bit NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var60 sysname;
    SELECT @var60 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IdTipoTicket');
    IF @var60 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var60 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IdTipoTicket] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var61 sysname;
    SELECT @var61 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IdFamiliaItemsOrigen');
    IF @var61 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var61 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IdFamiliaItemsOrigen] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var62 sysname;
    SELECT @var62 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IdDeposito');
    IF @var62 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var62 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IdDeposito] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var63 sysname;
    SELECT @var63 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IdArticuloTransformadoCC');
    IF @var63 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var63 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IdArticuloTransformadoCC] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var64 sysname;
    SELECT @var64 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IdArticuloTransformado');
    IF @var64 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var64 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IdArticuloTransformado] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var65 sysname;
    SELECT @var65 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IDVendedor');
    IF @var65 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var65 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IDVendedor] smallint NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var66 sysname;
    SELECT @var66 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IDRubroFranquicia');
    IF @var66 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var66 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IDRubroFranquicia] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var67 sysname;
    SELECT @var67 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IDProveedorUltimaCompra');
    IF @var67 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var67 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IDProveedorUltimaCompra] smallint NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var68 sysname;
    SELECT @var68 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IDMonedaOriginal');
    IF @var68 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var68 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IDMonedaOriginal] smallint NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var69 sysname;
    SELECT @var69 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'IDMoneda');
    IF @var69 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var69 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [IDMoneda] smallint NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var70 sysname;
    SELECT @var70 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'FechaUltimaCompra');
    IF @var70 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var70 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [FechaUltimaCompra] datetime2 NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var71 sysname;
    SELECT @var71 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'FechaExistenciaInicial');
    IF @var71 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var71 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [FechaExistenciaInicial] datetime2 NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var72 sysname;
    SELECT @var72 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'ExistenciaMinima');
    IF @var72 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var72 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [ExistenciaMinima] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var73 sysname;
    SELECT @var73 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'ExistenciaInicial');
    IF @var73 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var73 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [ExistenciaInicial] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    DECLARE @var74 sysname;
    SELECT @var74 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Articulos]') AND [c].[name] = N'ExistenciaActual');
    IF @var74 IS NOT NULL EXEC(N'ALTER TABLE [Articulos] DROP CONSTRAINT [' + @var74 + '];');
    ALTER TABLE [Articulos] ALTER COLUMN [ExistenciaActual] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Porcentaje10] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Porcentaje4] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Porcentaje5] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Porcentaje6] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Porcentaje7] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Porcentaje8] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Porcentaje9] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [PorcentajeMarcacion] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [PorcentajeMarcacionDos] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [PorcentajeMarcacionTres] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Precio01] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Precio02] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Precio03] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Precio04] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Precio05] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Precio06] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Precio07] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Precio08] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Precio09] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [Precio10] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [PrecioCosto] decimal(18,2) NOT NULL DEFAULT 0.0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    ALTER TABLE [Articulos] ADD [PrecioUltimaCompra] decimal(18,2) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200512153158_CambiosEnArticulo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200512153158_CambiosEnArticulo', N'3.1.2');
END;

GO

