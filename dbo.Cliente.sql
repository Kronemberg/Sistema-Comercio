CREATE TABLE [dbo].[Cliente] (
    [Id]   NVARCHAR (50)  NOT NULL,
    [senha] NVARCHAR(50) NULL, 
    [email] NVARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

