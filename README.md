-- Script to Create Table // 

USE [InventoryWebApiDB]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 07-12-2020 23:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[InventoryId] [int] IDENTITY(0,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [numeric](18, 0) NOT NULL,
	[Quantity] [numeric](18, 0) NOT NULL,
	[CreatedDate] [date] NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[InventoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
