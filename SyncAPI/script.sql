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

