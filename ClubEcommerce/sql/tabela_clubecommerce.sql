IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [Products] (
    [Sku] varchar(50) NOT NULL,
    [Name] varchar(15) NOT NULL,
    [Description] varchar(100) NOT NULL,
    [Price] decimal(18,2) NOT NULL,
    [StockQuantity] int NOT NULL,
    [Id] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([Sku])
);

CREATE TABLE [Images] (
    [Id] uniqueidentifier NOT NULL,
    [Url] varchar(130) NOT NULL,
    [AltText] varchar(70) NOT NULL,
    [IsPrimary] bit NOT NULL,
    [ProductSku] varchar(50) NOT NULL,
    CONSTRAINT [PK_Images] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Images_Products_ProductSku] FOREIGN KEY ([ProductSku]) REFERENCES [Products] ([Sku]) ON DELETE CASCADE
);

CREATE INDEX [IX_Images_ProductSku] ON [Images] ([ProductSku]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250305153247_Initial-Create', N'9.0.2');

COMMIT;
GO

